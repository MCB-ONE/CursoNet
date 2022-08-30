namespace ClassLibrary1
{
    public class Snippets
    {
        static public void MultipleSelcts()
        {
            //SELECT MANY
            string[] myOpinions =
            {
                "Opinion 1, Text 1",
                "Opinion 2, Text 2",
                "Opinion 3, Text 3",
            };
            var myOpinioSelection = myOpinions.SelectMany(opinion => opinion.Split(","));
        }
    }

    
}