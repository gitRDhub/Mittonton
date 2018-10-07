using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hinderscript : MonoBehaviour {

    GameObject Grid; //Unityちゃんそのものが入る変数

    GridManager script; //UnityChanScriptが入る変数


    // Use this for initialization
    void Start () {
        Grid = GameObject.Find("Grid"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        script = Grid.GetComponent<GridManager>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
    }

    public void ButtonPush()
    {
        script.hindersamon(); //UnityChanScriptにある関数Attackを実行する
    }
}
