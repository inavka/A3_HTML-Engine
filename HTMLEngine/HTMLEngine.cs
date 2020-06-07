namespace HTML
{ 
  // HTML engine for generation of a HTML string from an array of HTML tag elements:

  public interface ITagged { string TagId { get; } }  // Used to define HTML tag element

  public interface INested { object[] Elements { get; } }  // Used to "mark" a HTML tag element as nested

    
    public static class Engine
  {
    public static string Generate(params object[] elements)
    {
            // TODO: Your code for (recursive) generation of a HTML string from array "elements" here...
            string html = "";
            foreach (object item in elements)
            {   
                //1. case: item has a tag and can store other elements 
                if(item is ITagged && item is INested)
                { 
                    //recursive Generate funktion 
                    html += $"<{((ITagged)item).TagId}> {Generate(((INested)item).Elements)}</{((ITagged)item).TagId}>";
                }
                //2. case: item has only tag
                else if(item is ITagged)
                {
                    html += $"<{((ITagged)item).TagId}>"; 
                }
                //3. case: item is neither taged nor nested
                else
                {
                    html += item.ToString();
                }
            }
            return html;
    }
  }
}