using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;

namespace pure_selenium.PageObjects
{
   public class Main:BaseSection
    {
        public Main(string css= "main.content-wrapper") :base(css)
        {
        }
        public string QuoteText()=> Scope.FindElement(By.XPath(".site-content q")).Text;
        public void ClickFeedbackLink(string link) => Scope.FindElement(By.XPath($"//p[@class='thank']/a[.='{link}']"))
            .Click();
        public void ClickButton(string button) => Scope.FindElement(By.XPath($"//input[@value='{button}']"))
            .Click();
        public void FillInName(string value) => Scope.FindElement(By.CssSelector("input#Name")).SendKeys(value);
        public void FillInEmail(string value) => Scope.FindElement(By.CssSelector("input#Email")).SendKeys(value);
        public void FillInComment(string value) => Scope.FindElement(By.CssSelector("input#Comment")).SendKeys(value);
        public IEnumerable<IWebElement> Comments => Scope.FindElements(By.CssSelector("blockquote"));
        public string LastCommentText => Scope.FindElement(By.CssSelector(".container blockquote:last-child p")).Text;
        public string LastCommentAuthor => Scope.FindElement(By.CssSelector(".container blockquote:last-child cite")).Text;
        public string ErrorMessageText(string field) => Scope
            .FindElement(By.XPath($"//span[contains(@class,'text-danger')]/span[@for='{field}']")).Text;

        public IEnumerable<IWebElement> GalleryImages() => Scope.FindElements(By.CssSelector(".gal img"));
        public bool BrokenImagesExist() => GalleryImages().All(img => string.IsNullOrEmpty(img.GetAttribute("src")));
    }
}
