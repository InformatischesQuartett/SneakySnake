/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class Object : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Object(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Object obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Object() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          cppPINVOKE.delete_Object(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Object() : this(cppPINVOKE.new_Object(), true) {
  }

  public void type(Object.type_enum value) {
    cppPINVOKE.Object_type(swigCPtr, (int)value);
  }

  public void mode(Object.mode_enum value) {
    cppPINVOKE.Object_mode(swigCPtr, (int)value);
  }

  public SWIGTYPE_p_bool layers() {
    global::System.IntPtr cPtr = cppPINVOKE.Object_layers__SWIG_0(swigCPtr);
    SWIGTYPE_p_bool ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
    return ret;
  }

  public void layers(SWIGTYPE_p_bool values) {
    cppPINVOKE.Object_layers__SWIG_1(swigCPtr, SWIGTYPE_p_bool.getCPtr(values));
  }

  public SWIGTYPE_p_bool layers_local_view() {
    global::System.IntPtr cPtr = cppPINVOKE.Object_layers_local_view__SWIG_0(swigCPtr);
    SWIGTYPE_p_bool ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
    return ret;
  }

  public void layers_local_view(SWIGTYPE_p_bool values) {
    cppPINVOKE.Object_layers_local_view__SWIG_1(swigCPtr, SWIGTYPE_p_bool.getCPtr(values));
  }

  public bool select() {
    bool ret = cppPINVOKE.Object_select__SWIG_0(swigCPtr);
    return ret;
  }

  public void select(int value) {
    cppPINVOKE.Object_select__SWIG_1(swigCPtr, value);
  }

  public float bound_box() {
    float ret = cppPINVOKE.Object_bound_box__SWIG_0(swigCPtr);
    return ret;
  }

  public void bound_box(float[] /* float[]_cstype */ values) {
    cppPINVOKE.Object_bound_box__SWIG_1(swigCPtr,  values /* float[]_csin */);
  }

  public void parent_type(Object.parent_type_enum value) {
    cppPINVOKE.Object_parent_type(swigCPtr, (int)value);
  }

  public SWIGTYPE_p_int parent_vertices() {
    global::System.IntPtr cPtr = cppPINVOKE.Object_parent_vertices__SWIG_0(swigCPtr);
    SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
    return ret;
  }

  public void parent_vertices(int[] /* int[]_cstype */ values) {
    cppPINVOKE.Object_parent_vertices__SWIG_1(swigCPtr,  values /* int[]_csin */);
  }

  public string parent_bone() {
    string ret = cppPINVOKE.Object_parent_bone__SWIG_0(swigCPtr);
    return ret;
  }

  public void parent_bone(string value) {
    cppPINVOKE.Object_parent_bone__SWIG_1(swigCPtr, value);
    if (cppPINVOKE.SWIGPendingException.Pending) throw cppPINVOKE.SWIGPendingException.Retrieve();
  }

  public void track_axis(Object.track_axis_enum value) {
    cppPINVOKE.Object_track_axis(swigCPtr, (int)value);
  }

  public void up_axis(Object.up_axis_enum value) {
    cppPINVOKE.Object_up_axis(swigCPtr, (int)value);
  }

  public int active_material_index() {
    int ret = cppPINVOKE.Object_active_material_index__SWIG_0(swigCPtr);
    return ret;
  }

  public void active_material_index(int value) {
    cppPINVOKE.Object_active_material_index__SWIG_1(swigCPtr, value);
  }

  public float location() {
    float ret = cppPINVOKE.Object_location__SWIG_0(swigCPtr);
    return ret;
  }

  public void location(Fusee.Math.float3 /* float[3]_cstype */ values) {
    cppPINVOKE.Object_location__SWIG_1(swigCPtr,  values /* float[3]_csin */);
  }

  public float rotation_quaternion() {
    float ret = cppPINVOKE.Object_rotation_quaternion__SWIG_0(swigCPtr);
    return ret;
  }

  public void rotation_quaternion(float[] /* float[]_cstype */ values) {
    cppPINVOKE.Object_rotation_quaternion__SWIG_1(swigCPtr,  values /* float[]_csin */);
  }

  public float rotation_axis_angle() {
    float ret = cppPINVOKE.Object_rotation_axis_angle__SWIG_0(swigCPtr);
    return ret;
  }

  public void rotation_axis_angle(float[] /* float[]_cstype */ values) {
    cppPINVOKE.Object_rotation_axis_angle__SWIG_1(swigCPtr,  values /* float[]_csin */);
  }

  public float rotation_euler() {
    float ret = cppPINVOKE.Object_rotation_euler__SWIG_0(swigCPtr);
    return ret;
  }

  public void rotation_euler(Fusee.Math.float3 /* float[3]_cstype */ values) {
    cppPINVOKE.Object_rotation_euler__SWIG_1(swigCPtr,  values /* float[3]_csin */);
  }

  public void rotation_mode(Object.rotation_mode_enum value) {
    cppPINVOKE.Object_rotation_mode(swigCPtr, (int)value);
  }

  public float scale() {
    float ret = cppPINVOKE.Object_scale__SWIG_0(swigCPtr);
    return ret;
  }

  public void scale(Fusee.Math.float3 /* float[3]_cstype */ values) {
    cppPINVOKE.Object_scale__SWIG_1(swigCPtr,  values /* float[3]_csin */);
  }

  public float dimensions() {
    float ret = cppPINVOKE.Object_dimensions__SWIG_0(swigCPtr);
    return ret;
  }

  public void dimensions(Fusee.Math.float3 /* float[3]_cstype */ values) {
    cppPINVOKE.Object_dimensions__SWIG_1(swigCPtr,  values /* float[3]_csin */);
  }

  public float delta_location() {
    float ret = cppPINVOKE.Object_delta_location__SWIG_0(swigCPtr);
    return ret;
  }

  public void delta_location(Fusee.Math.float3 /* float[3]_cstype */ values) {
    cppPINVOKE.Object_delta_location__SWIG_1(swigCPtr,  values /* float[3]_csin */);
  }

  public float delta_rotation_euler() {
    float ret = cppPINVOKE.Object_delta_rotation_euler__SWIG_0(swigCPtr);
    return ret;
  }

  public void delta_rotation_euler(Fusee.Math.float3 /* float[3]_cstype */ values) {
    cppPINVOKE.Object_delta_rotation_euler__SWIG_1(swigCPtr,  values /* float[3]_csin */);
  }

  public float delta_rotation_quaternion() {
    float ret = cppPINVOKE.Object_delta_rotation_quaternion__SWIG_0(swigCPtr);
    return ret;
  }

  public void delta_rotation_quaternion(float[] /* float[]_cstype */ values) {
    cppPINVOKE.Object_delta_rotation_quaternion__SWIG_1(swigCPtr,  values /* float[]_csin */);
  }

  public float delta_scale() {
    float ret = cppPINVOKE.Object_delta_scale__SWIG_0(swigCPtr);
    return ret;
  }

  public void delta_scale(Fusee.Math.float3 /* float[3]_cstype */ values) {
    cppPINVOKE.Object_delta_scale__SWIG_1(swigCPtr,  values /* float[3]_csin */);
  }

  public SWIGTYPE_p_bool lock_location() {
    global::System.IntPtr cPtr = cppPINVOKE.Object_lock_location__SWIG_0(swigCPtr);
    SWIGTYPE_p_bool ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
    return ret;
  }

  public void lock_location(SWIGTYPE_p_bool values) {
    cppPINVOKE.Object_lock_location__SWIG_1(swigCPtr, SWIGTYPE_p_bool.getCPtr(values));
  }

  public SWIGTYPE_p_bool lock_rotation() {
    global::System.IntPtr cPtr = cppPINVOKE.Object_lock_rotation__SWIG_0(swigCPtr);
    SWIGTYPE_p_bool ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
    return ret;
  }

  public void lock_rotation(SWIGTYPE_p_bool values) {
    cppPINVOKE.Object_lock_rotation__SWIG_1(swigCPtr, SWIGTYPE_p_bool.getCPtr(values));
  }

  public bool lock_rotation_w() {
    bool ret = cppPINVOKE.Object_lock_rotation_w__SWIG_0(swigCPtr);
    return ret;
  }

  public void lock_rotation_w(int value) {
    cppPINVOKE.Object_lock_rotation_w__SWIG_1(swigCPtr, value);
  }

  public bool lock_rotations_4d() {
    bool ret = cppPINVOKE.Object_lock_rotations_4d__SWIG_0(swigCPtr);
    return ret;
  }

  public void lock_rotations_4d(int value) {
    cppPINVOKE.Object_lock_rotations_4d__SWIG_1(swigCPtr, value);
  }

  public SWIGTYPE_p_bool lock_scale() {
    global::System.IntPtr cPtr = cppPINVOKE.Object_lock_scale__SWIG_0(swigCPtr);
    SWIGTYPE_p_bool ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
    return ret;
  }

  public void lock_scale(SWIGTYPE_p_bool values) {
    cppPINVOKE.Object_lock_scale__SWIG_1(swigCPtr, SWIGTYPE_p_bool.getCPtr(values));
  }

  public float matrix_world() {
    float ret = cppPINVOKE.Object_matrix_world__SWIG_0(swigCPtr);
    return ret;
  }

  public void matrix_world(float[] /* float[]_cstype */ values) {
    cppPINVOKE.Object_matrix_world__SWIG_1(swigCPtr,  values /* float[]_csin */);
  }

  public float matrix_local() {
    float ret = cppPINVOKE.Object_matrix_local__SWIG_0(swigCPtr);
    return ret;
  }

  public void matrix_local(float[] /* float[]_cstype */ values) {
    cppPINVOKE.Object_matrix_local__SWIG_1(swigCPtr,  values /* float[]_csin */);
  }

  public float matrix_basis() {
    float ret = cppPINVOKE.Object_matrix_basis__SWIG_0(swigCPtr);
    return ret;
  }

  public void matrix_basis(float[] /* float[]_cstype */ values) {
    cppPINVOKE.Object_matrix_basis__SWIG_1(swigCPtr,  values /* float[]_csin */);
  }

  public float matrix_parent_inverse() {
    float ret = cppPINVOKE.Object_matrix_parent_inverse__SWIG_0(swigCPtr);
    return ret;
  }

  public void matrix_parent_inverse(float[] /* float[]_cstype */ values) {
    cppPINVOKE.Object_matrix_parent_inverse__SWIG_1(swigCPtr,  values /* float[]_csin */);
  }

  public void empty_draw_type(Object.empty_draw_type_enum value) {
    cppPINVOKE.Object_empty_draw_type(swigCPtr, (int)value);
  }

  public float empty_draw_size() {
    float ret = cppPINVOKE.Object_empty_draw_size__SWIG_0(swigCPtr);
    return ret;
  }

  public void empty_draw_size(float value) {
    cppPINVOKE.Object_empty_draw_size__SWIG_1(swigCPtr, value);
  }

  public float empty_image_offset() {
    float ret = cppPINVOKE.Object_empty_image_offset__SWIG_0(swigCPtr);
    return ret;
  }

  public void empty_image_offset(float[] /* float[]_cstype */ values) {
    cppPINVOKE.Object_empty_image_offset__SWIG_1(swigCPtr,  values /* float[]_csin */);
  }

  public int pass_index() {
    int ret = cppPINVOKE.Object_pass_index__SWIG_0(swigCPtr);
    return ret;
  }

  public void pass_index(int value) {
    cppPINVOKE.Object_pass_index__SWIG_1(swigCPtr, value);
  }

  public float color() {
    float ret = cppPINVOKE.Object_color__SWIG_0(swigCPtr);
    return ret;
  }

  public void color(float[] /* float[]_cstype */ values) {
    cppPINVOKE.Object_color__SWIG_1(swigCPtr,  values /* float[]_csin */);
  }

  public bool hide() {
    bool ret = cppPINVOKE.Object_hide__SWIG_0(swigCPtr);
    return ret;
  }

  public void hide(int value) {
    cppPINVOKE.Object_hide__SWIG_1(swigCPtr, value);
  }

  public bool hide_select() {
    bool ret = cppPINVOKE.Object_hide_select__SWIG_0(swigCPtr);
    return ret;
  }

  public void hide_select(int value) {
    cppPINVOKE.Object_hide_select__SWIG_1(swigCPtr, value);
  }

  public bool hide_render() {
    bool ret = cppPINVOKE.Object_hide_render__SWIG_0(swigCPtr);
    return ret;
  }

  public void hide_render(int value) {
    cppPINVOKE.Object_hide_render__SWIG_1(swigCPtr, value);
  }

  public bool use_slow_parent() {
    bool ret = cppPINVOKE.Object_use_slow_parent__SWIG_0(swigCPtr);
    return ret;
  }

  public void use_slow_parent(int value) {
    cppPINVOKE.Object_use_slow_parent__SWIG_1(swigCPtr, value);
  }

  public float slow_parent_offset() {
    float ret = cppPINVOKE.Object_slow_parent_offset__SWIG_0(swigCPtr);
    return ret;
  }

  public void slow_parent_offset(float value) {
    cppPINVOKE.Object_slow_parent_offset__SWIG_1(swigCPtr, value);
  }

  public bool use_extra_recalc_object() {
    bool ret = cppPINVOKE.Object_use_extra_recalc_object__SWIG_0(swigCPtr);
    return ret;
  }

  public void use_extra_recalc_object(int value) {
    cppPINVOKE.Object_use_extra_recalc_object__SWIG_1(swigCPtr, value);
  }

  public bool use_extra_recalc_data() {
    bool ret = cppPINVOKE.Object_use_extra_recalc_data__SWIG_0(swigCPtr);
    return ret;
  }

  public void use_extra_recalc_data(int value) {
    cppPINVOKE.Object_use_extra_recalc_data__SWIG_1(swigCPtr, value);
  }

  public void dupli_type(Object.dupli_type_enum value) {
    cppPINVOKE.Object_dupli_type(swigCPtr, (int)value);
  }

  public bool use_dupli_frames_speed() {
    bool ret = cppPINVOKE.Object_use_dupli_frames_speed__SWIG_0(swigCPtr);
    return ret;
  }

  public void use_dupli_frames_speed(int value) {
    cppPINVOKE.Object_use_dupli_frames_speed__SWIG_1(swigCPtr, value);
  }

  public bool use_dupli_vertices_rotation() {
    bool ret = cppPINVOKE.Object_use_dupli_vertices_rotation__SWIG_0(swigCPtr);
    return ret;
  }

  public void use_dupli_vertices_rotation(int value) {
    cppPINVOKE.Object_use_dupli_vertices_rotation__SWIG_1(swigCPtr, value);
  }

  public bool use_dupli_faces_scale() {
    bool ret = cppPINVOKE.Object_use_dupli_faces_scale__SWIG_0(swigCPtr);
    return ret;
  }

  public void use_dupli_faces_scale(int value) {
    cppPINVOKE.Object_use_dupli_faces_scale__SWIG_1(swigCPtr, value);
  }

  public float dupli_faces_scale() {
    float ret = cppPINVOKE.Object_dupli_faces_scale__SWIG_0(swigCPtr);
    return ret;
  }

  public void dupli_faces_scale(float value) {
    cppPINVOKE.Object_dupli_faces_scale__SWIG_1(swigCPtr, value);
  }

  public int dupli_frames_start() {
    int ret = cppPINVOKE.Object_dupli_frames_start__SWIG_0(swigCPtr);
    return ret;
  }

  public void dupli_frames_start(int value) {
    cppPINVOKE.Object_dupli_frames_start__SWIG_1(swigCPtr, value);
  }

  public int dupli_frames_end() {
    int ret = cppPINVOKE.Object_dupli_frames_end__SWIG_0(swigCPtr);
    return ret;
  }

  public void dupli_frames_end(int value) {
    cppPINVOKE.Object_dupli_frames_end__SWIG_1(swigCPtr, value);
  }

  public int dupli_frames_on() {
    int ret = cppPINVOKE.Object_dupli_frames_on__SWIG_0(swigCPtr);
    return ret;
  }

  public void dupli_frames_on(int value) {
    cppPINVOKE.Object_dupli_frames_on__SWIG_1(swigCPtr, value);
  }

  public int dupli_frames_off() {
    int ret = cppPINVOKE.Object_dupli_frames_off__SWIG_0(swigCPtr);
    return ret;
  }

  public void dupli_frames_off(int value) {
    cppPINVOKE.Object_dupli_frames_off__SWIG_1(swigCPtr, value);
  }

  public void is_duplicator(int value) {
    cppPINVOKE.Object_is_duplicator(swigCPtr, value);
  }

  public void draw_type(Object.draw_type_enum value) {
    cppPINVOKE.Object_draw_type(swigCPtr, (int)value);
  }

  public bool show_bounds() {
    bool ret = cppPINVOKE.Object_show_bounds__SWIG_0(swigCPtr);
    return ret;
  }

  public void show_bounds(int value) {
    cppPINVOKE.Object_show_bounds__SWIG_1(swigCPtr, value);
  }

  public void draw_bounds_type(Object.draw_bounds_type_enum value) {
    cppPINVOKE.Object_draw_bounds_type(swigCPtr, (int)value);
  }

  public bool show_name() {
    bool ret = cppPINVOKE.Object_show_name__SWIG_0(swigCPtr);
    return ret;
  }

  public void show_name(int value) {
    cppPINVOKE.Object_show_name__SWIG_1(swigCPtr, value);
  }

  public bool show_axis() {
    bool ret = cppPINVOKE.Object_show_axis__SWIG_0(swigCPtr);
    return ret;
  }

  public void show_axis(int value) {
    cppPINVOKE.Object_show_axis__SWIG_1(swigCPtr, value);
  }

  public bool show_texture_space() {
    bool ret = cppPINVOKE.Object_show_texture_space__SWIG_0(swigCPtr);
    return ret;
  }

  public void show_texture_space(int value) {
    cppPINVOKE.Object_show_texture_space__SWIG_1(swigCPtr, value);
  }

  public bool show_wire() {
    bool ret = cppPINVOKE.Object_show_wire__SWIG_0(swigCPtr);
    return ret;
  }

  public void show_wire(int value) {
    cppPINVOKE.Object_show_wire__SWIG_1(swigCPtr, value);
  }

  public bool show_all_edges() {
    bool ret = cppPINVOKE.Object_show_all_edges__SWIG_0(swigCPtr);
    return ret;
  }

  public void show_all_edges(int value) {
    cppPINVOKE.Object_show_all_edges__SWIG_1(swigCPtr, value);
  }

  public bool show_transparent() {
    bool ret = cppPINVOKE.Object_show_transparent__SWIG_0(swigCPtr);
    return ret;
  }

  public void show_transparent(int value) {
    cppPINVOKE.Object_show_transparent__SWIG_1(swigCPtr, value);
  }

  public bool show_x_ray() {
    bool ret = cppPINVOKE.Object_show_x_ray__SWIG_0(swigCPtr);
    return ret;
  }

  public void show_x_ray(int value) {
    cppPINVOKE.Object_show_x_ray__SWIG_1(swigCPtr, value);
  }

  public bool show_only_shape_key() {
    bool ret = cppPINVOKE.Object_show_only_shape_key__SWIG_0(swigCPtr);
    return ret;
  }

  public void show_only_shape_key(int value) {
    cppPINVOKE.Object_show_only_shape_key__SWIG_1(swigCPtr, value);
  }

  public bool use_shape_key_edit_mode() {
    bool ret = cppPINVOKE.Object_use_shape_key_edit_mode__SWIG_0(swigCPtr);
    return ret;
  }

  public void use_shape_key_edit_mode(int value) {
    cppPINVOKE.Object_use_shape_key_edit_mode__SWIG_1(swigCPtr, value);
  }

  public int active_shape_key_index() {
    int ret = cppPINVOKE.Object_active_shape_key_index__SWIG_0(swigCPtr);
    return ret;
  }

  public void active_shape_key_index(int value) {
    cppPINVOKE.Object_active_shape_key_index__SWIG_1(swigCPtr, value);
  }

  public bool use_dynamic_topology_sculpting() {
    bool ret = cppPINVOKE.Object_use_dynamic_topology_sculpting__SWIG_0(swigCPtr);
    return ret;
  }

  public void use_dynamic_topology_sculpting(int value) {
    cppPINVOKE.Object_use_dynamic_topology_sculpting__SWIG_1(swigCPtr, value);
  }

  public void calc_matrix_camera(float[] /* float[]_cstype */ result, int x, int y, float scale_x, float scale_y) {
    cppPINVOKE.Object_calc_matrix_camera(swigCPtr,  result /* float[]_csin */, x, y, scale_x, scale_y);
  }

  public void dupli_list_clear() {
    cppPINVOKE.Object_dupli_list_clear(swigCPtr);
  }

  public void ray_cast(Fusee.Math.float3 /* float[3]_cstype */ start, Fusee.Math.float3 /* float[3]_cstype */ end, Fusee.Math.float3 /* float[3]_cstype */ location, Fusee.Math.float3 /* float[3]_cstype */ normal, SWIGTYPE_p_int index) {
    cppPINVOKE.Object_ray_cast(swigCPtr,  start /* float[3]_csin */,  end /* float[3]_csin */,  location /* float[3]_csin */,  normal /* float[3]_csin */, SWIGTYPE_p_int.getCPtr(index));
  }

  public void closest_point_on_mesh(Fusee.Math.float3 /* float[3]_cstype */ point, float max_dist, Fusee.Math.float3 /* float[3]_cstype */ location, Fusee.Math.float3 /* float[3]_cstype */ normal, SWIGTYPE_p_int index) {
    cppPINVOKE.Object_closest_point_on_mesh(swigCPtr,  point /* float[3]_csin */, max_dist,  location /* float[3]_csin */,  normal /* float[3]_csin */, SWIGTYPE_p_int.getCPtr(index));
  }

  public bool update_from_editmode() {
    bool ret = cppPINVOKE.Object_update_from_editmode(swigCPtr);
    return ret;
  }

  public void cache_release() {
    cppPINVOKE.Object_cache_release(swigCPtr);
  }

  public enum type_enum {
    type_MESH = 1,
    type_CURVE = 2,
    type_SURFACE = 3,
    type_META = 5,
    type_FONT = 4,
    type_ARMATURE = 25,
    type_LATTICE = 22,
    type_EMPTY = 0,
    type_CAMERA = 11,
    type_LAMP = 10,
    type_SPEAKER = 12
  }

  public enum mode_enum {
    mode_OBJECT = 0,
    mode_EDIT = 1,
    mode_POSE = 64,
    mode_SCULPT = 2,
    mode_VERTEX_PAINT = 4,
    mode_WEIGHT_PAINT = 8,
    mode_TEXTURE_PAINT = 16,
    mode_PARTICLE_EDIT = 32
  }

  public enum parent_type_enum {
    parent_type_OBJECT = 0,
    parent_type_CURVE = 1,
    parent_type_KEY = 2,
    parent_type_ARMATURE = 4,
    parent_type_LATTICE = 4,
    parent_type_VERTEX = 5,
    parent_type_VERTEX_3 = 6,
    parent_type_BONE = 7
  }

  public enum track_axis_enum {
    track_axis_POS_X = 0,
    track_axis_POS_Y = 1,
    track_axis_POS_Z = 2,
    track_axis_NEG_X = 3,
    track_axis_NEG_Y = 4,
    track_axis_NEG_Z = 5
  }

  public enum up_axis_enum {
    up_axis_X = 0,
    up_axis_Y = 1,
    up_axis_Z = 2
  }

  public enum rotation_mode_enum {
    rotation_mode_QUATERNION = 0,
    rotation_mode_XYZ = 1,
    rotation_mode_XZY = 2,
    rotation_mode_YXZ = 3,
    rotation_mode_YZX = 4,
    rotation_mode_ZXY = 5,
    rotation_mode_ZYX = 6,
    rotation_mode_AXIS_ANGLE = -1
  }

  public enum empty_draw_type_enum {
    empty_draw_type_PLAIN_AXES = 2,
    empty_draw_type_ARROWS = 1,
    empty_draw_type_SINGLE_ARROW = 4,
    empty_draw_type_CIRCLE = 3,
    empty_draw_type_CUBE = 5,
    empty_draw_type_SPHERE = 6,
    empty_draw_type_CONE = 7,
    empty_draw_type_IMAGE = 8
  }

  public enum dupli_type_enum {
    dupli_type_NONE = 0,
    dupli_type_FRAMES = 8,
    dupli_type_VERTS = 16,
    dupli_type_FACES = 512,
    dupli_type_GROUP = 256
  }

  public enum draw_type_enum {
    draw_type_BOUNDS = 1,
    draw_type_WIRE = 2,
    draw_type_SOLID = 3,
    draw_type_TEXTURED = 5
  }

  public enum draw_bounds_type_enum {
    draw_bounds_type_BOX = 0,
    draw_bounds_type_SPHERE = 1,
    draw_bounds_type_CYLINDER = 2,
    draw_bounds_type_CONE = 3,
    draw_bounds_type_CAPSULE = 7
  }

}