using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_App.Models
{
    public class GoodReadsAuthor
    {


        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class GoodreadsResponse
        {

            private GoodreadsResponseRequest requestField;

            private GoodreadsResponseAuthor authorField;

            /// <remarks/>
            public GoodreadsResponseRequest Request
            {
                get
                {
                    return this.requestField;
                }
                set
                {
                    this.requestField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseAuthor author
            {
                get
                {
                    return this.authorField;
                }
                set
                {
                    this.authorField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseRequest
        {

            private bool authenticationField;

            private string keyField;

            private string methodField;

            /// <remarks/>
            public bool authentication
            {
                get
                {
                    return this.authenticationField;
                }
                set
                {
                    this.authenticationField = value;
                }
            }

            /// <remarks/>
            public string key
            {
                get
                {
                    return this.keyField;
                }
                set
                {
                    this.keyField = value;
                }
            }

            /// <remarks/>
            public string method
            {
                get
                {
                    return this.methodField;
                }
                set
                {
                    this.methodField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseAuthor
        {

            private ushort idField;

            private string nameField;

            private string linkField;

            private GoodreadsResponseAuthorFans_count fans_countField;

            private GoodreadsResponseAuthorAuthor_followers_count author_followers_countField;

            private string large_image_urlField;

            private string image_urlField;

            private string small_image_urlField;

            private object aboutField;

            private object influencesField;

            private byte works_countField;

            private string genderField;

            private string hometownField;

            private object born_atField;

            private object died_atField;

            private bool goodreads_authorField;

            private GoodreadsResponseAuthorUser userField;

            private GoodreadsResponseAuthorBook[] booksField;

            /// <remarks/>
            public ushort id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string link
            {
                get
                {
                    return this.linkField;
                }
                set
                {
                    this.linkField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseAuthorFans_count fans_count
            {
                get
                {
                    return this.fans_countField;
                }
                set
                {
                    this.fans_countField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseAuthorAuthor_followers_count author_followers_count
            {
                get
                {
                    return this.author_followers_countField;
                }
                set
                {
                    this.author_followers_countField = value;
                }
            }

            /// <remarks/>
            public string large_image_url
            {
                get
                {
                    return this.large_image_urlField;
                }
                set
                {
                    this.large_image_urlField = value;
                }
            }

            /// <remarks/>
            public string image_url
            {
                get
                {
                    return this.image_urlField;
                }
                set
                {
                    this.image_urlField = value;
                }
            }

            /// <remarks/>
            public string small_image_url
            {
                get
                {
                    return this.small_image_urlField;
                }
                set
                {
                    this.small_image_urlField = value;
                }
            }

            /// <remarks/>
            public object about
            {
                get
                {
                    return this.aboutField;
                }
                set
                {
                    this.aboutField = value;
                }
            }

            /// <remarks/>
            public object influences
            {
                get
                {
                    return this.influencesField;
                }
                set
                {
                    this.influencesField = value;
                }
            }

            /// <remarks/>
            public byte works_count
            {
                get
                {
                    return this.works_countField;
                }
                set
                {
                    this.works_countField = value;
                }
            }

            /// <remarks/>
            public string gender
            {
                get
                {
                    return this.genderField;
                }
                set
                {
                    this.genderField = value;
                }
            }

            /// <remarks/>
            public string hometown
            {
                get
                {
                    return this.hometownField;
                }
                set
                {
                    this.hometownField = value;
                }
            }

            /// <remarks/>
            public object born_at
            {
                get
                {
                    return this.born_atField;
                }
                set
                {
                    this.born_atField = value;
                }
            }

            /// <remarks/>
            public object died_at
            {
                get
                {
                    return this.died_atField;
                }
                set
                {
                    this.died_atField = value;
                }
            }

            /// <remarks/>
            public bool goodreads_author
            {
                get
                {
                    return this.goodreads_authorField;
                }
                set
                {
                    this.goodreads_authorField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseAuthorUser user
            {
                get
                {
                    return this.userField;
                }
                set
                {
                    this.userField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("book", IsNullable = false)]
            public GoodreadsResponseAuthorBook[] books
            {
                get
                {
                    return this.booksField;
                }
                set
                {
                    this.booksField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseAuthorFans_count
        {

            private string typeField;

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public ushort Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseAuthorAuthor_followers_count
        {

            private string typeField;

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public ushort Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseAuthorUser
        {

            private GoodreadsResponseAuthorUserID idField;

            /// <remarks/>
            public GoodreadsResponseAuthorUserID id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseAuthorUserID
        {

            private string typeField;

            private uint valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public uint Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseAuthorBook
        {

            private GoodreadsResponseAuthorBookID idField;

            private GoodreadsResponseAuthorBookIsbn isbnField;

            private GoodreadsResponseAuthorBookIsbn13 isbn13Field;

            private GoodreadsResponseAuthorBookText_reviews_count text_reviews_countField;

            private string uriField;

            private string titleField;

            private string title_without_seriesField;

            private string image_urlField;

            private string small_image_urlField;

            private object large_image_urlField;

            private string linkField;

            private string num_pagesField;

            private string formatField;

            private object edition_informationField;

            private string publisherField;

            private string publication_dayField;

            private string publication_yearField;

            private string publication_monthField;

            private decimal average_ratingField;

            private ushort ratings_countField;

            private string descriptionField;

            private GoodreadsResponseAuthorBookAuthors authorsField;

            private string publishedField;

            private GoodreadsResponseAuthorBookWork workField;

            /// <remarks/>
            public GoodreadsResponseAuthorBookID id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseAuthorBookIsbn isbn
            {
                get
                {
                    return this.isbnField;
                }
                set
                {
                    this.isbnField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseAuthorBookIsbn13 isbn13
            {
                get
                {
                    return this.isbn13Field;
                }
                set
                {
                    this.isbn13Field = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseAuthorBookText_reviews_count text_reviews_count
            {
                get
                {
                    return this.text_reviews_countField;
                }
                set
                {
                    this.text_reviews_countField = value;
                }
            }

            /// <remarks/>
            public string uri
            {
                get
                {
                    return this.uriField;
                }
                set
                {
                    this.uriField = value;
                }
            }

            /// <remarks/>
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            public string title_without_series
            {
                get
                {
                    return this.title_without_seriesField;
                }
                set
                {
                    this.title_without_seriesField = value;
                }
            }

            /// <remarks/>
            public string image_url
            {
                get
                {
                    return this.image_urlField;
                }
                set
                {
                    this.image_urlField = value;
                }
            }

            /// <remarks/>
            public string small_image_url
            {
                get
                {
                    return this.small_image_urlField;
                }
                set
                {
                    this.small_image_urlField = value;
                }
            }

            /// <remarks/>
            public object large_image_url
            {
                get
                {
                    return this.large_image_urlField;
                }
                set
                {
                    this.large_image_urlField = value;
                }
            }

            /// <remarks/>
            public string link
            {
                get
                {
                    return this.linkField;
                }
                set
                {
                    this.linkField = value;
                }
            }

            /// <remarks/>
            public string num_pages
            {
                get
                {
                    return this.num_pagesField;
                }
                set
                {
                    this.num_pagesField = value;
                }
            }

            /// <remarks/>
            public string format
            {
                get
                {
                    return this.formatField;
                }
                set
                {
                    this.formatField = value;
                }
            }

            /// <remarks/>
            public object edition_information
            {
                get
                {
                    return this.edition_informationField;
                }
                set
                {
                    this.edition_informationField = value;
                }
            }

            /// <remarks/>
            public string publisher
            {
                get
                {
                    return this.publisherField;
                }
                set
                {
                    this.publisherField = value;
                }
            }

            /// <remarks/>
            public string publication_day
            {
                get
                {
                    return this.publication_dayField;
                }
                set
                {
                    this.publication_dayField = value;
                }
            }

            /// <remarks/>
            public string publication_year
            {
                get
                {
                    return this.publication_yearField;
                }
                set
                {
                    this.publication_yearField = value;
                }
            }

            /// <remarks/>
            public string publication_month
            {
                get
                {
                    return this.publication_monthField;
                }
                set
                {
                    this.publication_monthField = value;
                }
            }

            /// <remarks/>
            public decimal average_rating
            {
                get
                {
                    return this.average_ratingField;
                }
                set
                {
                    this.average_ratingField = value;
                }
            }

            /// <remarks/>
            public ushort ratings_count
            {
                get
                {
                    return this.ratings_countField;
                }
                set
                {
                    this.ratings_countField = value;
                }
            }

            /// <remarks/>
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseAuthorBookAuthors authors
            {
                get
                {
                    return this.authorsField;
                }
                set
                {
                    this.authorsField = value;
                }
            }

            /// <remarks/>
            public string published
            {
                get
                {
                    return this.publishedField;
                }
                set
                {
                    this.publishedField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseAuthorBookWork work
            {
                get
                {
                    return this.workField;
                }
                set
                {
                    this.workField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseAuthorBookID
        {

            private string typeField;

            private uint valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public uint Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseAuthorBookIsbn
        {

            private bool nilField;

            private bool nilFieldSpecified;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nil
            {
                get
                {
                    return this.nilField;
                }
                set
                {
                    this.nilField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool nilSpecified
            {
                get
                {
                    return this.nilFieldSpecified;
                }
                set
                {
                    this.nilFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseAuthorBookIsbn13
        {

            private bool nilField;

            private bool nilFieldSpecified;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nil
            {
                get
                {
                    return this.nilField;
                }
                set
                {
                    this.nilField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool nilSpecified
            {
                get
                {
                    return this.nilFieldSpecified;
                }
                set
                {
                    this.nilFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseAuthorBookText_reviews_count
        {

            private string typeField;

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseAuthorBookAuthors
        {

            private GoodreadsResponseAuthorBookAuthorsAuthor authorField;

            /// <remarks/>
            public GoodreadsResponseAuthorBookAuthorsAuthor author
            {
                get
                {
                    return this.authorField;
                }
                set
                {
                    this.authorField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseAuthorBookAuthorsAuthor
        {

            private ushort idField;

            private string nameField;

            private string roleField;

            private GoodreadsResponseAuthorBookAuthorsAuthorImage_url image_urlField;

            private GoodreadsResponseAuthorBookAuthorsAuthorSmall_image_url small_image_urlField;

            private string linkField;

            private decimal average_ratingField;

            private ushort ratings_countField;

            private ushort text_reviews_countField;

            /// <remarks/>
            public ushort id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string role
            {
                get
                {
                    return this.roleField;
                }
                set
                {
                    this.roleField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseAuthorBookAuthorsAuthorImage_url image_url
            {
                get
                {
                    return this.image_urlField;
                }
                set
                {
                    this.image_urlField = value;
                }
            }

            /// <remarks/>
            public GoodreadsResponseAuthorBookAuthorsAuthorSmall_image_url small_image_url
            {
                get
                {
                    return this.small_image_urlField;
                }
                set
                {
                    this.small_image_urlField = value;
                }
            }

            /// <remarks/>
            public string link
            {
                get
                {
                    return this.linkField;
                }
                set
                {
                    this.linkField = value;
                }
            }

            /// <remarks/>
            public decimal average_rating
            {
                get
                {
                    return this.average_ratingField;
                }
                set
                {
                    this.average_ratingField = value;
                }
            }

            /// <remarks/>
            public ushort ratings_count
            {
                get
                {
                    return this.ratings_countField;
                }
                set
                {
                    this.ratings_countField = value;
                }
            }

            /// <remarks/>
            public ushort text_reviews_count
            {
                get
                {
                    return this.text_reviews_countField;
                }
                set
                {
                    this.text_reviews_countField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseAuthorBookAuthorsAuthorImage_url
        {

            private bool nophotoField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nophoto
            {
                get
                {
                    return this.nophotoField;
                }
                set
                {
                    this.nophotoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseAuthorBookAuthorsAuthorSmall_image_url
        {

            private bool nophotoField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nophoto
            {
                get
                {
                    return this.nophotoField;
                }
                set
                {
                    this.nophotoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GoodreadsResponseAuthorBookWork
        {

            private uint idField;

            private string uriField;

            /// <remarks/>
            public uint id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string uri
            {
                get
                {
                    return this.uriField;
                }
                set
                {
                    this.uriField = value;
                }
            }
        }





    }
}
