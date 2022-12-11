#define wString

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

struct sString
{
    string key;
    string value;
}

#region TRIPLET
class Triplet<T>
{
    //constructor
    public Triplet(T t1, T t2, T t3)
    {
        this._triplet_unit_1 = t1;
        this._triplet_unit_2 = t2;
        this._triplet_unit_3 = t3;
    }
    //!constructor

    //destructor
    //
    //!destrcutor

    //member data
    T _triplet_unit_1;
    T _triplet_unit_2;
    T _triplet_unit_3;
    //!member data

    //operator overriding
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
               (_triplet_unit_1 == d_tr._triplet_unit_1 &&
                _triplet_unit_2 == d_tr._triplet_unit_2 &&
                _triplet_unit_3 == d_tr._triplet_unit_3);
    }
    public static bool operator ==(Triplet<T> lhs, Triplet<T> rhs)
    {
        dynamic d_lhs = lhs, d_rhs = rhs;
        return d_lhs._triplet_unit_1 == d_rhs._triplet_unit_1 &&
               d_lhs._triplet_unit_2 == d_rhs._triplet_unit_2 &&
               d_lhs._triplet_unit_3 == d_rhs._triplet_unit_3;
    }
    public static bool operator !=(Triplet<T> lhs, Triplet<T> rhs)
    {
        dynamic d_lhs = lhs, d_rhs = rhs;
        return d_lhs._triplet_unit_1 != d_rhs._triplet_unit_1 ||
               d_lhs._triplet_unit_2 != d_rhs._triplet_unit_2 ||
               d_lhs._triplet_unit_3 != d_rhs._triplet_unit_3;
    }
    public static bool operator >(Triplet<T> lhs, Triplet<T> rhs)
    {
        dynamic d_lhs = lhs, d_rhs = rhs;
        return (d_lhs._triplet_unit_1 + d_lhs._triplet_unit_2 + d_lhs._triplet_unit_3)
                >
               (d_rhs._triplet_unit_1 + d_rhs._triplet_unit_2 + d_rhs._triplet_unit_3);
    }
    public static bool operator <(Triplet<T> lhs, Triplet<T> rhs)
    {
        dynamic d_lhs = lhs, d_rhs = rhs;
        return (d_lhs._triplet_unit_1 + d_lhs._triplet_unit_2 + d_lhs._triplet_unit_3)
                <
               (d_rhs._triplet_unit_1 + d_rhs._triplet_unit_2 + d_rhs._triplet_unit_3);
    }
    //!operator overriding

    //fucntion override
    public override int GetHashCode()
    {
        return HashCode.Combine(_triplet_unit_1, _triplet_unit_2, _triplet_unit_3);
    }
    public override string ToString()
    {
        return "{\n" + "_triplet_unit_1 = " + _triplet_unit_1 +
               ",\n" + "_triplet_unit_2 = " + _triplet_unit_2 +
               ",\n" + "_triplet_unit_3 = " + _triplet_unit_3 + "\n}";
    }
    //!function override

    //custom functions
    public Triplet<string> CastToString(Triplet<int> tr)
    {
        return new Triplet<string>
        (
            tr._triplet_unit_1.ToString(),
            tr._triplet_unit_2.ToString(),
            tr._triplet_unit_3.ToString()
        );
    }
    public Triplet<int> CastToInt(Triplet<string> tr)
    {
        return new Triplet<int>
        (
            Int32.Parse(tr._triplet_unit_1),
            Int32.Parse(tr._triplet_unit_1),
            Int32.Parse(tr._triplet_unit_1)
        );
    }
    //!custom functions
}
#endregion //!TRIPLET

#region TRIPLET_CONTAINER
class TripletContainer<T>
{
    //constructor
    public TripletContainer(List<Triplet<T>> arr)
    {
        this.TC_arr = new List<Triplet<T>>(arr);
    }
    public TripletContainer(Int32 initCap)
    {
        this.TC_arr = new List<Triplet<T>>(initCap);
    }
    //!constructor

    //destructor
    //
    //!destructor

    //properties
    public int Capacity
    {
        get => this.TC_arr.Capacity;
        set { this.TC_arr.Capacity = value; }
    }
    public int Count
    {
        get => this.TC_arr.Count;
    }
    public Triplet<T> this[int index]
    {
        get => this.TC_arr[index];
        set { this.TC_arr[index] = value; }
    }
    //!properties

    //functions
    public void Add(Triplet<T> item)
    {
        this.TC_arr.Add(item);
    }
    public void Clear()
    {
        this.TC_arr.Clear();
    }
    public bool Contains(Triplet<T> item)
    {
        return this.TC_arr.Contains(item);
    }
    public void CopyTo(Triplet<T>[] array)
    {
        this.TC_arr.CopyTo(array);
    }
    public void CopyTo(Triplet<T>[] array, int arrayIndex)
    {
        this.TC_arr.CopyTo(array, arrayIndex);
    }
    public void CopyTo(int index, Triplet<T>[] array, int arrayIndex, int count)
    {
        this.TC_arr.CopyTo(index, array, arrayIndex, count);
    }
    public override bool Equals(Object? obj)
    {
        return this.TC_arr.Equals(obj);
    }
    public override int GetHashCode()
    {
        return this.TC_arr.GetHashCode();
    }
    public Triplet<T>? Find(Predicate<Triplet<T>> match)
    {
        return this.TC_arr.Find(match);
    }
    public void ForEach(Action<Triplet<T>> action)
    {
        this.TC_arr.ForEach(action);
    }
    public int IndexOf(Triplet<T> tr)
    {
        return this.TC_arr.IndexOf(tr);
    }
    //!functions

    //member data
    private List<Triplet<T>> TC_arr;
    //!member data
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