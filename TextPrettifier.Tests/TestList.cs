using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TextPrettifier.Tests
{
    using TextPrettifierLib;

    [TestClass]
    public class TestList
    {
        [TestMethod]
        public void Double_hyphen_to_dash()
        {
            TextPrettifier textPrettifier = new TextPrettifier();
            Assert.AreEqual("Hello–there", textPrettifier.PrettifyForWeb("Hello--there"));
        }

        [TestMethod]
        public void Space_after_comma()
        {
            TextPrettifier textPrettifier = new TextPrettifier();
            Assert.AreEqual("Hello, world", textPrettifier.PrettifyForWeb("Hello,world"));
        }

        [TestMethod]
        public void Nonbreaking_space_between_short_and_long_words()
        {
            TextPrettifier textPrettifier = new TextPrettifier();
            Assert.AreEqual("striking from a&nbsp;hidden", textPrettifier.PrettifyForWeb("striking from a hidden"));
        }

        [TestMethod]
        public void Nonbreaking_space_between_number_and_following_text()
        {
            TextPrettifier textPrettifier = new TextPrettifier();
            Assert.AreEqual("Price: 128&nbsp;credits", textPrettifier.PrettifyForWeb("Price: 128 credits"));
        }

        [TestMethod]
        public void Nonbreaking_space_between_long_and_short_words()
        {
            TextPrettifier textPrettifier = new TextPrettifier();
            Assert.AreEqual("Going&nbsp;on a&nbsp;bus", textPrettifier.PrettifyForWeb("Going on a bus"));
        }

        [TestMethod]
        public void Nonbreaking_space_around_dash()
        {
            TextPrettifier textPrettifier = new TextPrettifier();
            Assert.AreEqual("Perpetuum Mobile&nbsp;—&nbsp;Myth", textPrettifier.PrettifyForWeb("Perpetuum Mobile — Myth"));
        }


        [TestMethod]
        public void Ignore_text_inside_html_tags_1()
        {
            TextPrettifier textPrettifier = new TextPrettifier();
           
            Assert.AreEqual(
                    "striking from a&nbsp;hidden <span style=\"width: 3px\" title=\"not a big deal\">striking from a&nbsp;hidden</span>", 
                    textPrettifier.PrettifyForWeb("striking from a hidden <span style=\"width: 3px\" title=\"not a big deal\">striking from a hidden</span>"));
        }

        [TestMethod]
        public void Ignore_text_inside_html_tags_2()
        {
            TextPrettifier textPrettifier = new TextPrettifier();

            Assert.AreEqual(
                    "<table><tr><td title=\"here is the title\">here&nbsp;is the&nbsp;title <span title=\"here is the title\" >here&nbsp;is the&nbsp;title</span></td><td>abc<span title=\"here is the title\"> here&nbsp;is the&nbsp;title </span></td></tr></table>",
                    textPrettifier.PrettifyForWeb("<table><tr><td title=\"here is the title\">here is the title <span title=\"here is the title\" >here is the title</span></td><td>abc<span title=\"here is the title\"> here is the title </span></td></tr></table>"));

        }

    }
}
