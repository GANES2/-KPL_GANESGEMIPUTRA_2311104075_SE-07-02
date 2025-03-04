using System;
using System.Collections.Generic;

public class KodePos
{
    private static Dictionary<string, string> kodePosDict = new Dictionary<string, string> {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"}
    };

    public static string GetKodePos(string kelurahan)
    {
        return kodePosDict.ContainsKey(kelurahan) ? kodePosDict[kelurahan] : "Kode pos tidak ditemukan";
    }
}
