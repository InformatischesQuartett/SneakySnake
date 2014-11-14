// ConvTest.cc

#include <tchar.h>
#include <sstream>
#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <algorithm>
#include <regex>

using std::cout;
using std::endl;
using std::string;
using std::vector;
using std::regex;

#define is_rna_type(a, b) (regex_search(a, regex(b))) 

struct bpy_enum_param
{
	string name;
	string desc;
	string value;
};

struct bpy_enum
{
	string name;
	vector<bpy_enum_param> params;
};

enum rna_def_type
{
	rna_def_none,
	rna_def_unknown,
	rna_def_action,
	rna_def_actuator,
	rna_def_animation,
	rna_def_animviz,
	rna_def_armature,
	rna_def_boid,
	rna_def_boolean,
	rna_def_boolean_array,
	rna_def_boolean_layer,
	rna_def_boolean_layer_member,
	rna_def_boolean_vector,
	rna_def_brush,
	rna_def_camera,
	rna_def_cloth,
	rna_def_collection,
	rna_def_collection_runtime,
	rna_def_color,
	rna_def_constraint,
	rna_def_context,
	rna_def_controller,
	rna_def_curve,
	rna_def_dynamic_paint,
	rna_def_enum,
	rna_def_enum_flag,
	rna_def_enum_funcs,
	rna_def_fcurve,
	rna_def_float,
	rna_def_float_array,
	rna_def_float_color,
	rna_def_float_factor,
	rna_def_float_matrix,
	rna_def_float_percentage,
	rna_def_float_rotation,
	rna_def_float_vector,
	rna_def_float_vector_xyz,
	rna_def_fluidsim,
	rna_def_func_duplicate_pointers,
	rna_def_func_free_pointers,
	rna_def_function,
	rna_def_function_flag,
	rna_def_function_output,
	rna_def_function_return,
	rna_def_function_runtime,
	rna_def_function_ui_description,
	rna_def_gameproperty,
	rna_def_gpencil,
	rna_def_group,
	rna_def_id,
	rna_def_image,
	rna_def_int,
	rna_def_int_array,
	rna_def_int_vector,
	rna_def_key,
	rna_def_lamp,
	rna_def_lattice,
	rna_def_linestyle,
	rna_def_main,
	rna_def_main_actions,
	rna_def_main_armatures,
	rna_def_main_brushes,
	rna_def_main_cameras,
	rna_def_main_curves,
	rna_def_main_fonts,
	rna_def_main_gpencil,
	rna_def_main_groups,
	rna_def_main_images,
	rna_def_main_lamps,
	rna_def_main_lattices,
	rna_def_main_libraries,
	rna_def_main_linestyles,
	rna_def_main_masks,
	rna_def_main_materials,
	rna_def_main_meshes,
	rna_def_main_metaballs,
	rna_def_main_movieclips,
	rna_def_main_node_groups,
	rna_def_main_objects,
	rna_def_main_particles,
	rna_def_main_scenes,
	rna_def_main_screens,
	rna_def_main_sounds,
	rna_def_main_speakers,
	rna_def_main_texts,
	rna_def_main_textures,
	rna_def_main_window_managers,
	rna_def_main_worlds,
	rna_def_mask,
	rna_def_material,
	rna_def_mesh,
	rna_def_meta,
	rna_def_modifier,
	rna_def_movieclip,
	rna_def_nla,
	rna_def_nodetree,
	rna_def_object,
	rna_def_object_force,
	rna_def_packedfile,
	rna_def_particle,
	rna_def_pointer,
	rna_def_pointer_runtime,
	rna_def_pose,
	rna_def_property,
	rna_def_property_array,
	rna_def_property_boolean_array_default,
	rna_def_property_boolean_array_funcs_runtime,
	rna_def_property_boolean_default,
	rna_def_property_boolean_funcs,
	rna_def_property_boolean_funcs_runtime,
	rna_def_property_boolean_negative_sdna,
	rna_def_property_boolean_sdna,
	rna_def_property_clear_flag,
	rna_def_property_collection_active,
	rna_def_property_collection_funcs,
	rna_def_property_collection_sdna,
	rna_def_property_duplicate_pointers,
	rna_def_property_dynamic_array_funcs,
	rna_def_property_editable_array_func,
	rna_def_property_editable_func,
	rna_def_property_enum_bitflag_sdna,
	rna_def_property_enum_default,
	rna_def_property_enum_funcs,
	rna_def_property_enum_funcs_runtime,
	rna_def_property_enum_items,
	rna_def_property_enum_py_data,
	rna_def_property_enum_sdna,
	rna_def_property_flag,
	rna_def_property_float,
	rna_def_property_float_array_default,
	rna_def_property_float_array_funcs_runtime,
	rna_def_property_float_default,
	rna_def_property_float_funcs,
	rna_def_property_float_funcs_runtime,
	rna_def_property_float_sdna,
	rna_def_property_free_identifier,
	rna_def_property_free_pointers,
	rna_def_property_int_array_default,
	rna_def_property_int_array_funcs_runtime,
	rna_def_property_int_default,
	rna_def_property_int_funcs,
	rna_def_property_int_funcs_runtime,
	rna_def_property_int_sdna,
	rna_def_property_multi_array,
	rna_def_property_multidimensional_array,
	rna_def_property_pointer_funcs,
	rna_def_property_pointer_sdna,
	rna_def_property_range,
	rna_def_property_srna,
	rna_def_property_store,
	rna_def_property_string_default,
	rna_def_property_string_funcs,
	rna_def_property_string_funcs_runtime,
	rna_def_property_string_maxlength,
	rna_def_property_string_sdna,
	rna_def_property_struct_runtime,
	rna_def_property_struct_type,
	rna_def_property_subtype,
	rna_def_property_translation_context,
	rna_def_property_ui_icon,
	rna_def_property_ui_range,
	rna_def_property_ui_text,
	rna_def_property_update,
	rna_def_property_update_runtime,
	rna_def_py_data,
	rna_def_render,
	rna_def_rigidbody,
	rna_def_rna,
	rna_def_scene,
	rna_def_screen,
	rna_def_sculpt_paint,
	rna_def_sensor,
	rna_def_sequencer,
	rna_def_smoke,
	rna_def_sound,
	rna_def_space,
	rna_def_speaker,
	rna_def_string,
	rna_def_string_dir_path,
	rna_def_string_file_name,
	rna_def_string_file_path,
	rna_def_struct,
	rna_def_struct_clear_flag,
	rna_def_struct_duplicate_pointers,
	rna_def_struct_flag,
	rna_def_struct_free_pointers,
	rna_def_struct_identifier,
	rna_def_struct_idprops_func,
	rna_def_struct_name_property,
	rna_def_struct_nested,
	rna_def_struct_path_func,
	rna_def_struct_ptr,
	rna_def_struct_refine_func,
	rna_def_struct_register_funcs,
	rna_def_struct_sdna,
	rna_def_struct_sdna_from,
	rna_def_struct_translation_context,
	rna_def_struct_ui_icon,
	rna_def_struct_ui_text,
	rna_def_test,
	rna_def_text,
	rna_def_texture,
	rna_def_timeline_marker,
	rna_def_tracking,
	rna_def_ui,
	rna_def_userdef,
	rna_def_vfont,
	rna_def_wm,
	rna_def_world
};

struct fctparam
{
	string name;
	string type;
	string desc;
	bool required;
	string defval;
};

struct bpy_func
{
	string name;
	string desc;
	fctparam rettype;
	vector <fctparam> params;
	bool error;
};

vector<string> unsolved_refs;
