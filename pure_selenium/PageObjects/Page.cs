namespace pure_selenium.PageObjects
{
    public class Page
    {
        public Page()
        {
            Header=new Header();
            Main= new Main();
            Footer = new Footer();
        }
        public Header Header { get; set; }
        public Main Main { get; set; }
        public Footer Footer { get; set; }

    }
}
