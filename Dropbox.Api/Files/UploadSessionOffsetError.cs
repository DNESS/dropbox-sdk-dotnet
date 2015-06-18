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
    /// <para>Error structure for recovering the correct upload offset.</para>
    /// </summary>
    public sealed class UploadSessionOffsetError : enc.IEncodable<UploadSessionOffsetError>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionOffsetError" />
        /// class.</para>
        /// </summary>
        /// <param name="correctOffset">The offset up to which data has been collected.</param>
        public UploadSessionOffsetError(ulong correctOffset)
        {
            this.CorrectOffset = correctOffset;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionOffsetError" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public UploadSessionOffsetError()
        {
        }

        /// <summary>
        /// <para>The offset up to which data has been collected.</para>
        /// </summary>
        public ulong CorrectOffset { get; private set; }

        #region IEncodable<UploadSessionOffsetError> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<UploadSessionOffsetError>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<ulong>("correct_offset", this.CorrectOffset);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        UploadSessionOffsetError enc.IEncodable<UploadSessionOffsetError>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.CorrectOffset = obj.GetField<ulong>("correct_offset");
            }

            return this;
        }

        #endregion
    }
}