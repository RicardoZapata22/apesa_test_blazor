using apesa_test.Pages.Products;
using NUnit;
using Bunit;

namespace TestProducts
{
    [TestFixture]
    public class Tests: Bunit.TestContext
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestProductForm()
        {
            var page_products = RenderComponent<Products>();

            page_products.WaitForState(() => page_products.FindAll("#add-button").Count > 0, timeout: TimeSpan.FromSeconds(10));

            page_products.Find("#add-button").Click();

            page_products.WaitForState(() => page_products.FindAll("#productModal").Count > 0, timeout: TimeSpan.FromSeconds(5));

            var firstProductType = page_products.Find("li.dropdown-item");
            firstProductType.Click();
            page_products.WaitForState(() => page_products.FindAll("#name").Count > 0, timeout: TimeSpan.FromSeconds(5));


            var name_product_input = page_products.Find("#name");
            name_product_input.Change("Prestamo prueba");

            Assert.That(name_product_input.GetAttribute("value"), Is.EqualTo("Prestamo prueba"), "El campo de nombre debería contener el texto ingresado.");
        }
    }
}
