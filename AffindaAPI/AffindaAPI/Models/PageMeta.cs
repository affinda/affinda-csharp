// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The PageMeta. </summary>
    public partial class PageMeta
    {
        /// <summary> Initializes a new instance of PageMeta. </summary>
        /// <param name="id"></param>
        /// <param name="pageIndex"> Page number within the document, starts from 0. </param>
        /// <param name="image"> The URL to the image of the page. </param>
        /// <param name="height"> Height of the page&apos;s image in px. </param>
        /// <param name="width"> Width of the page&apos;s image in px. </param>
        /// <param name="rotation"> The degree of rotation applied to the page. Greater than 0 indicates clockwise rotation. Less than 0 indicates counter-clockwise rotation. </param>
        internal PageMeta(int id, int pageIndex, string image, float height, float width, int rotation)
        {
            Id = id;
            PageIndex = pageIndex;
            Image = image;
            Height = height;
            Width = width;
            Rotation = rotation;
        }

        /// <summary> Gets the id. </summary>
        public int Id { get; }
        /// <summary> Page number within the document, starts from 0. </summary>
        public int PageIndex { get; }
        /// <summary> The URL to the image of the page. </summary>
        public string Image { get; }
        /// <summary> Height of the page&apos;s image in px. </summary>
        public float Height { get; }
        /// <summary> Width of the page&apos;s image in px. </summary>
        public float Width { get; }
        /// <summary> The degree of rotation applied to the page. Greater than 0 indicates clockwise rotation. Less than 0 indicates counter-clockwise rotation. </summary>
        public int Rotation { get; }
    }
}
