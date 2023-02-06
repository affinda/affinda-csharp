using System;
using System.IO;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Document
    {
        private bool ValidateDocumentType(string expected)
        {
            return this.Meta?.Collection?.Extractor?.Identifier == expected;
        }

        private Meta PatchMeta(Meta unpatched)
        {
            if (unpatched == null) {
                return null;
            }
            // Unfortunately C# makes us write these out explicitly...
            // Update this with added/removed fields as required.
            return new Meta(
                identifier: unpatched.Identifier,
                fileName: unpatched.FileName,
                ready: unpatched.Ready,
                readyDt: unpatched.ReadyDt,
                failed: unpatched.Failed,
                expiryTime: unpatched.ExpiryTime,
                language: unpatched.Language,
                pdf: unpatched.Pdf,
                parentDocument: unpatched.ParentDocument,
                childDocuments: unpatched.ChildDocuments,
                pages: unpatched.Pages,
                reviewUrl: unpatched.ReviewUrl,
                ocrConfidence: unpatched.OcrConfidence,
                // Patch: isVerified is sourced from IsConfirmed
                isVerified: Meta?.IsConfirmed
            );
        }

        public JobDescription AsJobDescription()
        {
            if (!ValidateDocumentType("job-description"))
            {
                throw new InvalidOperationException("Document does not appear to be a job description.");
            }
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);
            writer.WriteObjectValue(this);
            writer.Flush();
            stream.Seek(0, SeekOrigin.Begin);
            var document = JsonDocument.Parse(stream);
            var jobDescription = JobDescription.DeserializeJobDescription(document.RootElement);
            return new JobDescription(
                data: jobDescription.Data,
                error: jobDescription.Error,
                meta: this.PatchMeta(jobDescription.Meta)
            );
        }

        public Invoice AsInvoice()
        {
            if (!ValidateDocumentType("invoice"))
            {
                throw new InvalidOperationException("Document does not appear to be an invoice.");
            }
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);
            writer.WriteObjectValue(this);
            writer.Flush();
            stream.Seek(0, SeekOrigin.Begin);
            var document = JsonDocument.Parse(stream);
            var invoice = Invoice.DeserializeInvoice(document.RootElement);
            return new Invoice(
                clientVerifiedDt: this.Meta?.ConfirmedDt?.UtcDateTime.ToString("o"),
                data: invoice.Data,
                error: invoice.Error,
                meta: this.PatchMeta(invoice.Meta)
            );
        }

        public Resume AsResume()
        {
            if (!ValidateDocumentType("resume"))
            {
                throw new InvalidOperationException("Document does not appear to be a resume.");
            }
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);
            writer.WriteObjectValue(this);
            writer.Flush();
            stream.Seek(0, SeekOrigin.Begin);
            var document = JsonDocument.Parse(stream);
            var resume = Resume.DeserializeResume(document.RootElement);
            return new Resume(
                data: resume.Data,
                error: resume.Error,
                meta: this.PatchMeta(resume.Meta)
            );
        }
    }
}
