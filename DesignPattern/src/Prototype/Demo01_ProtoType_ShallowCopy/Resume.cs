using System;

namespace Demo01_ProtoType_ShallowCopy
{
    internal class Resume : ICloneable
    {
        private readonly string _name;
        private string _sex;
        private string _age;
        private string _timeArea;
        private string _company;
        public Resume(string name)
        {
            _name = name;
        }

        public void SetPersonalInfo(string sex, string age)
        {
            _sex = sex;
            _age = age;
        }

        public void SetWorkExperience(string timeArea, string company)
        {
            _timeArea = timeArea;
            _company = company;
        }

        public void Display()
        {
            Console.WriteLine($"{_name} {_sex} {_age}");
            Console.WriteLine($"工作经历:{_timeArea} {_company}");
        }

        public object Clone()
        {
            /*
             创建当前对象的浅表副本.方法是创建一个新的对象,然后将当前对象的非静态字段复制到该新对象.如果字段是值类型
             则对该字段执行逐位复制.如果字段是引用类型,则复制引用但不复制引用的对象;因此原始对象及其副本引用同一个对象
             */
            //在当前对象,实现的其实是深拷贝,因为string很特殊,它表现的如值类型一样,即对它进行赋值,分割,合并,并不是对原有字符串进行操作,而是返回一个新的字符串对象.
            return MemberwiseClone();
        }
    }
}
