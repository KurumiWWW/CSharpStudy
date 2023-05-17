using System.Collections.Specialized;

namespace _003 {
  class Program {
    static void Main(string[] args) {
      Demo d = new Demo();

      d.formatStr();
    }
  }

  class Demo {
    public void printFun() {
      //char a = 'c';
      //int b = a;
      //Console.WriteLine(b); // 99 ascii
      int a = 97;
      //char b = a; // 错误 整数类型过大，无法转换为char类型
      char b = (char)a; // 强转 如果大于目标类型 多出部分会丢失
      Console.WriteLine(b);
    }

    public void inputFun() {
      Console.WriteLine(@"c:\\a 

      ""
      \b\c");
      // 引号前加@符 引号內部转义符可变为普通字符 支持直接换行，连续两个双引号输出为引号

      //string str = Console.ReadLine(); // 从控制台读取输入一行内容 返回字符串
      //Console.WriteLine(str);

      int strInt = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("用户输入了：" + strInt);
    }

    public void formatStr() {
      // 字符串格式化输出
      int a = 1, b = 2;
      Console.WriteLine("格式化输出：{0}+{1}={2}", a, b, a + b);
    }
  }
}