//define most common use cases
//of Vector2<T> class 
using Vector2u = Vector2<uint>;
using Vector2i = Vector2<int>;
using Vector2f = Vector2<float>;

//includes
using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;
//!includes

#pragma warning disable 0169

#region sString
public struct sString
{
    public string key;
    public string value;
}
#endregion

#region TRIPLET
public class Triplet<T>
{
    //constructor
    public Triplet(T t1, T t2, T t3)
    {
        this.unit_1 = t1;
        this.unit_2 = t2;
        this.unit_3 = t3;
    }
    //!constructor

    //destructor
    //
    //!destrcutor

    //member data
    public T unit_1 { get; set; }
    public T unit_2 { get; set; }
    public T unit_3 { get; set; }
    //!member data

    //operator overriding
    public T this[int index]
    {
        get {
            if(index == 1) return this.unit_1;
            else if (index == 2) return this.unit_2;
            else if (index == 3) return this.unit_3;
            else throw new IndexOutOfRangeException();
        }
        set {
            if (index == 1) this.unit_1 = value;
            else if (index == 2) this.unit_2 = value;
            else if (index == 3) this.unit_3 = value;
            else throw new IndexOutOfRangeException();
        }
    }
    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        return base.Equals(obj as Triplet<T>);
    }
    public bool Equals(Triplet<T> tr)
    {
        //dynamic -> https://stackoverflow.com/questions/14020486/operator-overloading-with-generics
        dynamic d_tr = tr;
        return (d_tr is not null) &&
               (unit_1 == d_tr.unit_1 &&
                unit_2 == d_tr.unit_2 &&
                unit_3 == d_tr.unit_3);
    }
    public static bool operator ==(Triplet<T> lhs, Triplet<T> rhs)
    {
        dynamic d_lhs = lhs, d_rhs = rhs;
        return d_lhs.unit_1 == d_rhs.unit_1 &&
               d_lhs.unit_2 == d_rhs.unit_2 &&
               d_lhs.unit_3 == d_rhs.unit_3;
    }
    public static bool operator !=(Triplet<T> lhs, Triplet<T> rhs)
    {
        dynamic d_lhs = lhs, d_rhs = rhs;
        return d_lhs.unit_1 != d_rhs.unit_1 ||
               d_lhs.unit_2 != d_rhs.unit_2 ||
               d_lhs.unit_3 != d_rhs.unit_3;
    }
    public static bool operator >(Triplet<T> lhs, Triplet<T> rhs)
    {
        dynamic d_lhs = lhs, d_rhs = rhs;
        return (d_lhs.unit_1 + d_lhs.unit_2 + d_lhs.unit_3)
                >
               (d_rhs.unit_1 + d_rhs.unit_2 + d_rhs.unit_3);
    }
    public static bool operator <(Triplet<T> lhs, Triplet<T> rhs)
    {
        dynamic d_lhs = lhs, d_rhs = rhs;
        return (d_lhs.unit_1 + d_lhs.unit_2 + d_lhs.unit_3)
                <
               (d_rhs.unit_1 + d_rhs.unit_2 + d_rhs.unit_3);
    }
    //!operator overriding

    //fucntion override
    public override int GetHashCode()
    {
        return HashCode.Combine(unit_1, unit_2, unit_3);
    }
    public override string ToString()
    {
        return "{\n" + "_triplet_unit_1 = " + unit_1 +
               ",\n" + "_triplet_unit_2 = " + unit_2 +
               ",\n" + "_triplet_unit_3 = " + unit_3 + "\n}";
    }
    //!function override

    //custom functions
    public Triplet<string> CastToString(Triplet<int> tr)
    {
        return new Triplet<string>
        (
            tr.unit_1.ToString(),
            tr.unit_2.ToString(),
            tr.unit_3.ToString()
        );
    }
    public Triplet<int> CastToInt(Triplet<string> tr)
    {
        return new Triplet<int>
        (
            Int32.Parse(tr.unit_1),
            Int32.Parse(tr.unit_1),
            Int32.Parse(tr.unit_1)
        );
    }
    //!custom functions
}
#endregion //!TRIPLET

#region TRIPLET_CONTAINER
public enum TripletConPos { START, END, ALL }
public class TripletContainer<T> : IList<Triplet<T>>
{
    private List<Triplet<T>> tripletCon;
    private IEnumerable<Triplet<T>> tripletConLoader;
    public TripletContainer()
        : base() { }
    public TripletContainer(IEnumerable<Triplet<T>> tripletConLoader)
    {
        this.tripletConLoader = tripletConLoader;
        tripletCon = new List<Triplet<T>>(this.tripletConLoader);
    }
    public TripletContainer(List<Triplet<T>> tripletCon)
    {
        this.tripletCon = tripletCon;
    }
    public TripletContainer(int cap)
    {
        this.tripletCon = new List<Triplet<T>>(cap);
    }
    private void ensureList()
    {
        if (tripletCon == null)
            tripletCon = new List<Triplet<T>>(tripletConLoader);
    }
    public int SumAt(int initVal, TripletContainer<int> l)
    {
        for (int i = 0; i < l.Count; i++)
            initVal += l[i].unit_1 + l[i].unit_2 + l[i].unit_3;

        return initVal;
    }
    public int SumAt(int initVal, Triplet<int> tr)
    {
        initVal += tr.unit_1 + tr.unit_2 + tr.unit_3;
        return initVal;
    }
    public TripletContainer<T> GetRange(int start, int end)
    {
        return new TripletContainer<T>(tripletCon.GetRange(start, end));
    }
    public TripletContainer<T> GetRange(TripletConPos pos)
    {
        switch(pos)
        {
            case TripletConPos.ALL:
                return GetRange(0, tripletCon.Count);
            case TripletConPos.START:
                return GetRange(0, 0);
            case TripletConPos.END:
                return GetRange(tripletCon.Count, tripletCon.Count);
        }
        return null;
    }
    #region ILIST<T> MEMBERS
    public int IndexOf(Triplet<T> item)
    {
        ensureList();
        return tripletCon.IndexOf(item);
    }
    public void Insert(int index, Triplet<T> item)
    {
        ensureList();
        tripletCon.Insert(index, item);
    }
    public void RemoveAt(int index)
    {
        ensureList();
        tripletCon.RemoveAt(index);
    }
    public Triplet<T> this[int index]
    {
        get
        {
            ensureList();
            return tripletCon[index];
        }
        set
        {
            ensureList();
            tripletCon[index] = value;
        }
    }
    #endregion
    public void Add(Triplet<T> item)
    {
        ensureList();
        tripletCon.Add(item);
    }
    public void Clear()
    {
        ensureList();
        tripletCon.Clear();
    }
    public bool Contains(Triplet<T> item)
    {
        ensureList();
        return tripletCon.Contains(item);
    }
    public void CopyTo(Triplet<T>[] array, int arrayIndex)
    {
        ensureList();
        tripletCon.CopyTo(array, arrayIndex);
    }
    public int Count
    {
        get { ensureList(); return tripletCon.Count; }
    }
    public bool IsReadOnly
    {
        get { return false; }
    }

    Triplet<T> IList<Triplet<T>>.this[int index] { 
        get { 
            ensureList();
            return tripletCon[index]; 
        }
        set {
            ensureList();
            tripletCon[index] = value;
        }
    }

    public bool Remove(Triplet<T> item)
    {
        ensureList();
        return tripletCon.Remove(item);
    }
    public IEnumerator<Triplet<T>> GetEnumerator()
    {
        ensureList();
        return tripletCon.GetEnumerator();
    }
    #region IENUMERABLE_MEMBERS
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        ensureList();
        return tripletCon.GetEnumerator();
    }
    #endregion //!IENUMERABLE_MEMBERS
}
#endregion //!TRIPLET_CONTAINER

#region VECTOR2
class Vector2<T>
{
    //constructor
    public Vector2(T x, T y)
    {
        this.x = x;
        this.y = y;
    }
    //member data
    public T x;
    public T y;
    //!member data
}
#endregion //!VECTOR2

#region CODEMATRIX
class CodeMatrix
{
    //constructor
    public CodeMatrix() { }
    public CodeMatrix(char type)
    {
        install(type);
    }
    //!constructor
    //functions
    public void install(char type) { }
    public char get_symbol(Vector2i pos)
    {
        return CM_arr[pos.x][pos.y];
    }
    //!functions
    //known values
    public static int height = CM_arr.Count;
    public static int width = CM_arr[0].Count;
    //!known values
    private static List<List<char>> CM_arr = new List<List<char>>();
}
#endregion //!CODEMATRIX=

#pragma warning restore 0169