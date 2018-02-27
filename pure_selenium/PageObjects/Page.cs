namespace pure_selenium.PageObjects
{
    public class Page
    {
        public Page()
        {
            Header=new Header();
            Main= new Main();
            Footer=new Footer();
        }
        public Header Header { get; }
        public Main Main { get; }
        public Footer Footer { get; }

    }
}
