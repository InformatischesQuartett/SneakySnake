/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class cpp_file : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal cpp_file(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(cpp_file obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~cpp_file() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          cppPINVOKE.delete_cpp_file(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public cpp_file() : this(cppPINVOKE.new_cpp_file(), true) {
  }

  public int times2(int arg) {
    int ret = cppPINVOKE.cpp_file_times2(swigCPtr, arg);
    return ret;
  }

  public float test1(ref Fusee.Math.float3 /* Vector*&_cstype */ vec3) {
    float ret = cppPINVOKE.cpp_file_test1(swigCPtr,  ref vec3 /* float*&_csin */);
    return ret;
  }

  public float test2(SWIGTYPE_p_float vec) {
    float ret = cppPINVOKE.cpp_file_test2(swigCPtr, SWIGTYPE_p_float.getCPtr(vec));
    return ret;
  }

}
