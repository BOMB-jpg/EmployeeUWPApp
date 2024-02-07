
using System.ComponentModel;


namespace EmployeeComponent
{
    // 类表明它具有属性值更改通知的能力  这对于在 MVVM（Model-View-ViewModel）模式中非常常见，用于维护数据模型与视图之间的同步。  
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        private string _firstName = "";

        public EmployeeViewModel()
        {


        }
        public int Id { get; set; }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
             //set 访问器中，属性首先检查新值是否与旧值相同，
             //如果相同则不进行任何操作，直接返回。如果新值与旧值不同，那么将新值赋给 _firstName 字段，
             //并调用 NotifyPropertyChanged("FirstName") 方法通知属性更改
                if (_firstName == value) return;
                _firstName = value;
                NotifyPropertyChanged("FirstName"); // 下面有定义如何进行广播通知改变的定义
            }
        }
        public string LastName { get; set; }  //自动属性
        public decimal AnnualSalary { get; set; }
        public char Gender { get; set; }
        public bool IsManager { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;  //事件委托
  
        private void NotifyPropertyChanged(string propertyName)
        {

             //上述声明的事件名为 propertychanged  ？是用来查看是否为null如果不为null invoke执行后面的方法
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));    
            // 这里的new PropertyChangedEventArgs(propertyName)   这里的是创建的了一个新的实例
            //PropertyChangedEventArgs 类包含了两个重要的属性：
             //PropertyName：用于存储发生变化的属性的名称。
              //EventArgs：用于存储其它相关的事件参数。
        }

    }
}
