using NUnit.Framework;
using NUnit.Framework.Internal;
//using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace MvideoWindowsForms
{
    [TestFixture]

    class MockService : Configuration_class
    {
        [Test]
        public void Test()
        {
            //объявление формы для теста
            Klient_Form klient = new Klient_Form();
            //переменная для запроса
            string ds1;
            //запись в переменную значение запроса
            ds1 = klient.sqlstr;
            //проверка переменной с запросом на пустое значение 
            Assert.IsNotNull(ds1);
        }
    }

    class class1
    {
        [Test]
        public void Test1()
        {
            //объявление формы для теста
            PositionForm position = new PositionForm();
            //переменная для запроса
            string ds1;
            //запись в переменную значение запроса
            ds1 = position.sqlstr;
            //проверка переменной с запросом на пустое значение 
            Assert.IsNotNull(ds1);
        }
    }


    class class2
    {
        [Test]
        public void Test2()
        {
            //объявление формы для теста
            EducationForm education = new EducationForm();
            //переменная для запроса
            string ds1;
            //запись в переменную значение запроса
            ds1 = education.sqlstr;
            //проверка переменной с запросом на пустое значение 
            Assert.IsNotNull(ds1);
        }
    }

    class class3
    {
        [Test]
        public void Test3()
        {
            //объявление формы для теста
            SupplierForm supplier = new SupplierForm();
            //переменная для запроса
            string ds1;
            //запись в переменную значение запроса
            ds1 = supplier.sqlstr;
            //проверка переменной с запросом на пустое значение 
            Assert.IsNotNull(ds1);
        }
    }
}