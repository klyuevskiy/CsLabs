﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using InputString;

/*
Взять за основу задачу 6. Должно быть не менее 3 классов, которые наследуются от абстрактного класса. 
Используя рефлексию реализовать возможность создания  и вызова методов данных классов на форме.
Написать код, который принимает путь к библиотеке классов и ищет все классы, которые реализуют интерфейс.
Далее получают всю информацию о данных классах, и возвращают список из названий классов. На форме реализовать «дроплаун» с названиями классов.
При выборе класса на форму должны динамически подгружаться все методы класса с возможностью ввода параметров пользователем.
При нажатии кнопки «Выполнить» должен создаваться объект и выполняться выбранный метод.
*/

namespace Lab4.Main
{
    public partial class MainForm : Form
    {
        Assembly Models;
        IEnumerable<Type> types;

        Type currentType;
        object currentObject;

        MethodInfo currentMethod;
        object[] methodParameters;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Models = Assembly.Load("Lab4.Models");

            // получим все абстарктные типы, реализующие интерфейс
            types = Models.GetTypes()
                .Where(type => type.GetInterface("IFurniture") != null && !type.IsAbstract);

            // fill types combo box

            selectTypeComboBox.Items.AddRange(types.Select(type => type.Name).ToArray());
        }

        void FillMethodsComboBox()
        {
            selectMethodComboBox.Items.Clear();

            // получим методы object, чтобы исключить их при выборе

            IEnumerable<string> objectMethods = (new object()).GetType()
                .GetMethods().Select(method => method.Name);

            // также исклбчим get_ set_

            selectMethodComboBox.Items.AddRange(currentType.GetMethods()
                .Where(method => !objectMethods.Contains(method.Name) &&
                method.Name.Substring(0, 4) != "get_" &&
                method.Name.Substring(0, 4) != "set_")
                .Select(method => method.Name).ToArray());
        }

        private void selectTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentType = types.First(type => type.Name == selectTypeComboBox.SelectedItem.ToString());

            // update object, because update type
            currentObject = null;

            // fill methods combo box
            FillMethodsComboBox();

            // разрешаем выбрать метод и создать объект
            createObjectButton.Enabled = true;
            selectMethodComboBox.Enabled = true;

            // запрещаем ввести параметры и запустить метод
            inputParametersButton.Enabled = false;
            startMethodButton.Enabled = false;

            // update class => clear object info
            PropertiesListBox.Items.Clear();
        }

        private void selectMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMethod = currentType.GetMethods()
                .First(method => method.Name == selectMethodComboBox.SelectedItem.ToString());

            // если нет параметов и создан объект то разрешим зпускать метод
            // если нет параметорв, то оставим кнопку введения праметов отклбчёной

            startMethodButton.Enabled = false;

            if (currentMethod.GetParameters().Length == 0)
            {
                inputParametersButton.Enabled = false;
                startMethodButton.Enabled = currentObject != null;
            }
            else
                inputParametersButton.Enabled = true;

            // update parameters

            methodParameters = null;

            // show parameters

            ParametersListBox.Items.Clear();

            foreach (var item in currentMethod.GetParameters())
            {
                ParametersListBox.Items.Add(item.Name);
            }
        }

        bool InputBool(string message)
        {
            return MessageBox.Show(message, "input answer", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        object InputNumber(string message, string numberType)
        {
            // опредлеим валидатор в зависимости от типа
            IStringValidator validator;

            if (numberType == typeof(double).Name)
                validator = new NotNegativeDoubleValidator();
            else
                validator = new NotNegativeIntValidator();

            InputStringDialog inputNumber = new InputStringDialog(validator, message);

            if (inputNumber.ShowDialog() == DialogResult.OK)
            {
                if (numberType == typeof(double).Name)
                    return Double.Parse(inputNumber.Value);
                else
                    return Int32.Parse(inputNumber.Value);
            }

            return 0;
        }

        object InputObject(Type type)
        {
            MessageBox.Show($"input {type.Name} object");

            object newObject = Activator.CreateInstance(type);

            foreach (var item in type.GetProperties())
            {
                if (item.PropertyType == typeof(bool))
                    item.SetValue(newObject, InputBool(item.Name + "?"));
                else
                    item.SetValue(newObject, InputNumber("input " + item.Name, item.PropertyType.Name));
            }

            return newObject;
        }

        void ShowObjectProperties()
        {
            PropertiesListBox.Items.Clear();

            foreach (var item in currentType.GetProperties())
            {
                PropertiesListBox.Items.Add(item.Name + ": " + item.GetValue(currentObject));
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            currentObject = InputObject(currentType);

            if (currentMethod?.GetParameters().Length == 0)
                startMethodButton.Enabled = true;

            ShowObjectProperties();
        }

        private void inputParametersButton_Click(object sender, EventArgs e)
        {
            // если нет парметров

            if (currentMethod.GetParameters()[0].ParameterType.Name == "IFurniture")
                methodParameters = new object[1] { InputObject(currentType) };
            else if (currentMethod.GetParameters().Length != 0)
                methodParameters = currentMethod.GetParameters()
                    .Select(param => (param.ParameterType == typeof(bool)
                    ? InputBool(param.Name + "?")
                    : InputNumber("input" + param.Name, param.ParameterType.Name)))
                    .ToArray();

            if (currentObject != null)
                startMethodButton.Enabled = true;
        }

        private void startMethodButton_Click(object sender, EventArgs e)
        {
            if (currentMethod.ReturnType == typeof(void))
            {
                currentMethod.Invoke(currentObject, methodParameters);
                MessageBox.Show("Метод выполнен");
            }
            else
                MessageBox.Show(currentMethod.Invoke(currentObject, methodParameters).ToString());

            ShowObjectProperties();
        }
    }
}
