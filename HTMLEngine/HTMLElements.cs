namespace HTML
{
    class DocumentType : ITagged
    {
        public string TagId => "!DOCTYPE html";
    }
    //class of tagged and nested elements are similar and have same structure 
    class Html : ITagged, INested
    {
        public string TagId => "html"; //tag
        public object[] Elements { get; private set; } //array of stored elements
        public Html(params object[] Elements) //item constructor
        {
            this.Elements = Elements;
        }
    }
    class Head : ITagged, INested
    {
        public string TagId => "head";
        public object[] Elements { get; private set; }
        public Head(params object[] Elements)
        {
            this.Elements = Elements;
        }  
    }

    class Title : ITagged, INested
    {
        public string TagId => "title";
        public object[] Elements { get; private set; }
        public Title(params object[] Elements)
        {
            this.Elements = Elements;
        }
    }

    class Body : ITagged, INested
    {
        public string TagId => "body";
        public object[] Elements { get; private set; }
        public Body(params object[] Elements)
        {
            this.Elements = Elements;
        }
    }

    class Heading : ITagged, INested
    {
        public string TagId => "h1";
        public object[] Elements { get; private set; }
        public Heading(params object[] Elements)
        {
            this.Elements = Elements;
        }
    }

    class Paragraph : ITagged, INested
    {
        public string TagId => "p";
        public object[] Elements { get; private set; }
        public Paragraph(params object[] Elements)
        {
            this.Elements = Elements;
        }
    }

    class Italic : ITagged, INested
    {
        public string TagId => "i";
        public object[] Elements { get; private set; }
        public Italic(params object[] Elements)
        {
            this.Elements = Elements;
        }
    }

    class Bold : ITagged, INested
    {
        public string TagId => "b";
        public object[] Elements { get; private set; }
        public Bold(params object[] Elements)
        {
            this.Elements = Elements;
        }
    }

    class LineBreak : ITagged
    {
        public string TagId => "br/";
    }
}