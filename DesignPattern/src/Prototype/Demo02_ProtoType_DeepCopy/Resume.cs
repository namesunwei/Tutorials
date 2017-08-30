using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_ProtoType_DeepCopy
{
    internal class Resume : ICloneable
    {
        private string _name;
        private string _sex;
        private string _age;
        private readonly WorkExperience _workExperience;

        public Resume(string name)
        {
            _name = name;
            _workExperience = new WorkExperience();
        }

        private Resume(ICloneable work)
        {
            _workExperience = (WorkExperience)work.Clone();
        }

        public void SetPersonalInfo(string sex, string age)
        {
            _sex = sex;
            _age = age;
        }

        public void SetWorkExperience(string workDate, string company)
        {
            _workExperience.WorkDate = workDate;
            _workExperience.Company = company;
        }

        public void Display()
        {
            Console.Write($"{_name} {_sex} {_age} ");
            Console.WriteLine($"工作经历:{_workExperience.WorkDate} {_workExperience.Company}");
        }

        public object Clone()
        {
            /*
             调用私有的构造函数方法,让"工作经历"克隆完成,然后再给这个"简历"对象的相关字段复制,
             最终返回一个深复制的简历对象
             */

            //这里是通过实例化一个新的对象,该对象与原对象是2个相对独立的个体,然后将当前对象的值赋给新的对象,实现深拷贝.
            var obj = new Resume(_workExperience)
            {
                _name = _name,
                _age = _age,
                _sex = _sex
            };
            return obj;
        }
    }
}
