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
            return this.Meta?.Collection?.Extractor?.Identifier == expected || this.Meta?.Collection?.Extractor?.BaseExtractor == expected;
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
            return JobDescription.DeserializeJobDescription(document.RootElement);
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
            return Invoice.DeserializeInvoice(document.RootElement);
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
            return Resume.DeserializeResume(document.RootElement);
        }
    }
}
