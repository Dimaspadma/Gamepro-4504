using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectMovement : MonoBehaviour
{
    [Range(0,6)] public int aksi;
    public float speed;
    private Vector3 kekanan, kekiri, keatas, kebawah, maju, mundur;
    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3(1, 0, 0);
        kekiri = new Vector3(-1, 0, 0);
        keatas = new Vector3(0, 1, 0);
        kebawah = new Vector3(0,-1,0);

        maju = new Vector3(0, 0, 1);
        mundur = new Vector3(0, 0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        switch (aksi)
        {
            case 0:
                //translasi ke kanan
                transform.position += kekanan * (Time.deltaTime * speed);
                break;
            case 1:
                //translasi ke kiri
                
                // transform.Translate(kekiri * (Time.deltaTime * speed)); // ke kiri sesuai panah merah local
                
                transform.position += kekiri * (Time.deltaTime * speed); // kekiri sesuai panah merah world
                break;
            case 2:
                //translasi ke atas
                transform.position += keatas * (Time.deltaTime * speed);
                break;
            case 3:
                //translasi ke bawah
                
                // transform.Translate(kebawah * (Time.deltaTime * speed)); // ke bawah sesuai panah hijau local

                transform.position += kebawah * (Time.deltaTime * speed); // ke bawah sesuai panah hijau world
                
                break;
            case 4:
                //rotasi ke kanan
                transform.rotation *= RotasiObjek.ToQuaternion(maju * (Time.deltaTime * speed));
                break;
            case 5:
                //rotasi ke kiri
                transform.rotation *= RotasiObjek.ToQuaternion(mundur * (Time.deltaTime * speed));
                break;
        }
    }
}
