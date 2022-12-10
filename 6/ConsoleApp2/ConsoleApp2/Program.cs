using System;
using System.Collections.Generic;

class Sotrudniki
{
    string imya_;
    int Vozrast_;
    bool kuryachi_;

    public string imya
    {
        get { return imya_; }
        set { imya_ = value; }
    }

    public int Vozrast
    {
        get { return Vozrast_; }
        set { Vozrast_ = value; }
    }

    public bool kuryachi
    {
        get { return kuryachi_; }
        set { kuryachi_ = value; }
    }
}

class Zadanya6_2
{
    static void Main()
    {
        List<Sotrudniki> ludi = new List<Sotrudniki>();
        Sotrudniki oa = new Sotrudniki();
        oa.imya = "Tretyakov Andrey"; oa.Vozrast = 20; oa.kuryachi = true; ludi.Add(oa);
        Sotrudniki nb = new Sotrudniki();
        nb.imya = "Nikolay Bazenov"; nb.Vozrast = 19; nb.kuryachi = false; ludi.Add(nb);
        Sotrudniki il = new Sotrudniki();
        il.imya = "Ivan Leps"; il.Vozrast = 23; il.kuryachi = false; ludi.Add(il);
        Sotrudniki oo = new Sotrudniki();
        oo.imya = "Tret Tretov"; oo.Vozrast = 23; oo.kuryachi = true; ludi.Add(oo);
        Sotrudniki kv = new Sotrudniki();
        kv.imya = "Konstantin Voronin"; kv.Vozrast = 45; kv.kuryachi = true; ludi.Add(kv);
        Sotrudniki nv = new Sotrudniki();
        nv.imya = "Nikolay Voronin"; nv.Vozrast = 66; nv.kuryachi = false; ludi.Add(nv);
        Sotrudniki gb = new Sotrudniki();
        gb.imya = "Gena Bukin"; gb.Vozrast = 37; gb.kuryachi = false; ludi.Add(gb);

        var sortirovka_ludi = new List<string>();

        foreach (Sotrudniki chelovek in ludi)
        {
            if (chelovek.Vozrast > 18 && chelovek.kuryachi == false) 
                sortirovka_ludi.Add(chelovek.imya);
        }

        sortirovka_ludi.Sort();

        foreach (string chelovek in sortirovka_ludi) Console.WriteLine(chelovek);
    }
}
