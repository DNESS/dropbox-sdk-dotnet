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
    /// <para>Your intent when writing a file to some path. This is used to determine what
    /// constitutes a conflict and what the autorename strategy is.</para>
    /// <para>In some situations, the conflict behavior is identical: (a) If the target path
    /// doesn't contain anything, the file is always written; no conflict. (b) If the target
    /// path contains a folder, it's always a conflict. (c) If the target path contains a file
    /// with identical contents, nothing gets written; no conflict.</para>
    /// <para>The conflict checking differs in the case where there's a file at the target path
    /// with contents different from the contents you're trying to write.</para>
    /// </summary>
    public class WriteMode : enc.IEncodable<WriteMode>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="WriteMode" /> class.</para>
        /// </summary>
        public WriteMode()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Add</para>
        /// </summary>
        public bool IsAdd
        {
            get
            {
                return this is Add;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Add, or <c>null</c>.</para>
        /// </summary>
        public Add AsAdd
        {
            get
            {
                return this as Add;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Overwrite</para>
        /// </summary>
        public bool IsOverwrite
        {
            get
            {
                return this is Overwrite;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Overwrite, or <c>null</c>.</para>
        /// </summary>
        public Overwrite AsOverwrite
        {
            get
            {
                return this as Overwrite;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Update</para>
        /// </summary>
        public bool IsUpdate
        {
            get
            {
                return this is Update;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Update, or <c>null</c>.</para>
        /// </summary>
        public Update AsUpdate
        {
            get
            {
                return this as Update;
            }
        }

        #region IEncodable<WriteMode> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<WriteMode>.Encode(enc.IEncoder encoder)
        {
            if (this.IsAdd)
            {
                ((enc.IEncodable<Add>)this).Encode(encoder);
            }
            else if (this.IsOverwrite)
            {
                ((enc.IEncodable<Overwrite>)this).Encode(encoder);
            }
            else if (this.IsUpdate)
            {
                ((enc.IEncodable<Update>)this).Encode(encoder);
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
        WriteMode enc.IEncodable<WriteMode>.Decode(enc.IDecoder decoder)
        {
            switch (decoder.GetUnionName())
            {
            case "add":
                return Add.Instance;
            case "overwrite":
                return Overwrite.Instance;
            case "update":
                using (var obj = decoder.GetObject())
                {
                    return new Update(obj.GetField<string>("update"));
                }
            default:
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        /// <summary>
        /// <para>Never overwrite the existing file. The autorename strategy is to append a
        /// number to the file name. For example, "document.txt" might become "document
        /// (2).txt".</para>
        /// </summary>
        public sealed class Add : WriteMode, enc.IEncodable<Add>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Add" /> class.</para>
            /// </summary>
            private Add()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Add</para>
            /// </summary>
            public static readonly Add Instance = new Add();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<Add>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "add");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Add enc.IEncodable<Add>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>Always overwrite the existing file. The autorename strategy is the same as it
        /// is for <see cref="Add" />.</para>
        /// </summary>
        public sealed class Overwrite : WriteMode, enc.IEncodable<Overwrite>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Overwrite" /> class.</para>
            /// </summary>
            private Overwrite()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Overwrite</para>
            /// </summary>
            public static readonly Overwrite Instance = new Overwrite();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<Overwrite>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "overwrite");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Overwrite enc.IEncodable<Overwrite>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>Overwrite if the given "rev" matches the existing file's "rev". The
        /// autorename strategy is to append the string "conflicted copy" to the file name. For
        /// example, "document.txt" might become "document (conflicted copy).txt" or "document
        /// (Panda's conflicted copy).txt".</para>
        /// </summary>
        public sealed class Update : WriteMode, enc.IEncodable<Update>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Update" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Update(string value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<Update>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "update");
                    obj.AddField("update", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Update enc.IEncodable<Update>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }
    }
}
