public class SimpleIndexers
{
    class IndexerExample
    {
        private string[] names = new string[10];
        public string this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }
    }
    public static void Main098(string[] args)
    {
        IndexerExample indexerExample = new IndexerExample();
        indexerExample[0] = "ram";
        indexerExample[1] = "shyam";
        for(int i=0;i<2;i++){
            Console.WriteLine(indexerExample[i]);
        }

    }
}