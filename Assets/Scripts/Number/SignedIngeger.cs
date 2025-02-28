using UnityEngine;

public class SignedIngeger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sbyte iSbyte = 127;
        short iInt16 = 32767;
        int iInt32 = 2147483647;
        long iInt64 = 9223372036845775807;

        Debug.Log("sbyte:" + iSbyte);
        Debug.Log("short:" + iInt16);
        Debug.Log("int:" + iInt32);
        Debug.Log("long:" + iInt64);

        byte iByte = 255;
        ushort iUInt16 = 65535;
        uint iUInt32 = 4294967295;
        ulong iUInt64 = 18446744073709551615;
        Debug.Log("byte:" + iByte);
        Debug.Log("ushort:" + iUInt16);
        Debug.Log("uint:" + iUInt32);
        Debug.Log("ulong:" + iUInt64);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
