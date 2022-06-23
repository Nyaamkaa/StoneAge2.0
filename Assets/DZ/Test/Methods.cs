using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
  
    void Start()
    {
        PrintStr1();
        PrintStr2("1234");

        PrintStr2("testc");


        PrintStr3("QQQQQQQQQQQQQQ", 2);
        print(PrintStr3("QQQQQQQQQQQQQQ", 2));
     
    }

     
    private void PrintStr1()
    {
        print("111111111");
    }

    private void PrintStr2(string s)
    {
        print("222222222" + s);
    }

    private string PrintStr3(string s, int i)
    {
        print("3333333333" + s);

        return "3 тип";
    }

}
