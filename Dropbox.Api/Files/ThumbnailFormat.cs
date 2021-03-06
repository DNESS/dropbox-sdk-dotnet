// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The thumbnail format object</para>
    /// </summary>
    public class ThumbnailFormat : enc.IEncodable<ThumbnailFormat>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ThumbnailFormat" />
        /// class.</para>
        /// </summary>
        public ThumbnailFormat()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Jpeg</para>
        /// </summary>
        public bool IsJpeg
        {
            get
            {
                return this is Jpeg;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Jpeg, or <c>null</c>.</para>
        /// </summary>
        public Jpeg AsJpeg
        {
            get
            {
                return this as Jpeg;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Png</para>
        /// </summary>
        public bool IsPng
        {
            get
            {
                return this is Png;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Png, or <c>null</c>.</para>
        /// </summary>
        public Png AsPng
        {
            get
            {
                return this as Png;
            }
        }

        #region IEncodable<ThumbnailFormat> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<ThumbnailFormat>.Encode(enc.IEncoder encoder)
        {
            if (this.IsJpeg)
            {
                ((enc.IEncodable<Jpeg>)this).Encode(encoder);
            }
            else if (this.IsPng)
            {
                ((enc.IEncodable<Png>)this).Encode(encoder);
            }
            else
            {
                throw new sys.InvalidOperationException();
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        ThumbnailFormat enc.IEncodable<ThumbnailFormat>.Decode(enc.IDecoder decoder)
        {
            switch (decoder.GetUnionName())
            {
            case "jpeg":
                return Jpeg.Instance;
            case "png":
                return Png.Instance;
            default:
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        /// <summary>
        /// <para>The jpeg object</para>
        /// </summary>
        public sealed class Jpeg : ThumbnailFormat, enc.IEncodable<Jpeg>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Jpeg" /> class.</para>
            /// </summary>
            private Jpeg()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Jpeg</para>
            /// </summary>
            public static readonly Jpeg Instance = new Jpeg();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<Jpeg>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "jpeg");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Jpeg enc.IEncodable<Jpeg>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The png object</para>
        /// </summary>
        public sealed class Png : ThumbnailFormat, enc.IEncodable<Png>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Png" /> class.</para>
            /// </summary>
            private Png()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Png</para>
            /// </summary>
            public static readonly Png Instance = new Png();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<Png>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "png");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Png enc.IEncodable<Png>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }
    }
}
