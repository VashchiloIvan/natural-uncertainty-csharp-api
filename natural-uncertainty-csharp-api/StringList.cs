//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NaturalUncertaintyCsharpApi {

public class StringList : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<string>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal StringList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StringList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(StringList obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~StringList() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libnatural_uncertaintyPINVOKE.delete_StringList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public StringList(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (string element in c) {
      this.Add(element);
    }
  }

  public StringList(global::System.Collections.Generic.IEnumerable<string> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (string element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public string this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < 0 || (uint)value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public bool IsEmpty {
    get {
      return empty();
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(string[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(string[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, string[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public string[] ToArray() {
    string[] array = new string[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<string> global::System.Collections.Generic.IEnumerable<string>.GetEnumerator() {
    return new StringListEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new StringListEnumerator(this);
  }

  public StringListEnumerator GetEnumerator() {
    return new StringListEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class StringListEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<string>
  {
    private StringList collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public StringListEnumerator(StringList collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public string Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (string)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public StringList() : this(libnatural_uncertaintyPINVOKE.new_StringList__SWIG_0(), true) {
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringList(StringList other) : this(libnatural_uncertaintyPINVOKE.new_StringList__SWIG_1(StringList.getCPtr(other)), true) {
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    libnatural_uncertaintyPINVOKE.StringList_Clear(swigCPtr);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(string x) {
    libnatural_uncertaintyPINVOKE.StringList_Add(swigCPtr, x);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = libnatural_uncertaintyPINVOKE.StringList_size(swigCPtr);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool empty() {
    bool ret = libnatural_uncertaintyPINVOKE.StringList_empty(swigCPtr);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = libnatural_uncertaintyPINVOKE.StringList_capacity(swigCPtr);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    libnatural_uncertaintyPINVOKE.StringList_reserve(swigCPtr, n);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringList(int capacity) : this(libnatural_uncertaintyPINVOKE.new_StringList__SWIG_2(capacity), true) {
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
  }

  private string getitemcopy(int index) {
    string ret = libnatural_uncertaintyPINVOKE.StringList_getitemcopy(swigCPtr, index);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private string getitem(int index) {
    string ret = libnatural_uncertaintyPINVOKE.StringList_getitem(swigCPtr, index);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, string val) {
    libnatural_uncertaintyPINVOKE.StringList_setitem(swigCPtr, index, val);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(StringList values) {
    libnatural_uncertaintyPINVOKE.StringList_AddRange(swigCPtr, StringList.getCPtr(values));
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringList GetRange(int index, int count) {
    global::System.IntPtr cPtr = libnatural_uncertaintyPINVOKE.StringList_GetRange(swigCPtr, index, count);
    StringList ret = (cPtr == global::System.IntPtr.Zero) ? null : new StringList(cPtr, true);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, string x) {
    libnatural_uncertaintyPINVOKE.StringList_Insert(swigCPtr, index, x);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, StringList values) {
    libnatural_uncertaintyPINVOKE.StringList_InsertRange(swigCPtr, index, StringList.getCPtr(values));
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    libnatural_uncertaintyPINVOKE.StringList_RemoveAt(swigCPtr, index);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    libnatural_uncertaintyPINVOKE.StringList_RemoveRange(swigCPtr, index, count);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
  }

  public static StringList Repeat(string value, int count) {
    global::System.IntPtr cPtr = libnatural_uncertaintyPINVOKE.StringList_Repeat(value, count);
    StringList ret = (cPtr == global::System.IntPtr.Zero) ? null : new StringList(cPtr, true);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    libnatural_uncertaintyPINVOKE.StringList_Reverse__SWIG_0(swigCPtr);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    libnatural_uncertaintyPINVOKE.StringList_Reverse__SWIG_1(swigCPtr, index, count);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, StringList values) {
    libnatural_uncertaintyPINVOKE.StringList_SetRange(swigCPtr, index, StringList.getCPtr(values));
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(string value) {
    bool ret = libnatural_uncertaintyPINVOKE.StringList_Contains(swigCPtr, value);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int IndexOf(string value) {
    int ret = libnatural_uncertaintyPINVOKE.StringList_IndexOf(swigCPtr, value);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(string value) {
    int ret = libnatural_uncertaintyPINVOKE.StringList_LastIndexOf(swigCPtr, value);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(string value) {
    bool ret = libnatural_uncertaintyPINVOKE.StringList_Remove(swigCPtr, value);
    if (libnatural_uncertaintyPINVOKE.SWIGPendingException.Pending) throw libnatural_uncertaintyPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
