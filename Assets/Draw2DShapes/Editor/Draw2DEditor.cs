using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace Draw2DShapesLite
{
    /// <summary>
    /// Editor for the Draw2D script
    /// </summary>
    [CustomEditor(typeof(Draw2D))]
    public class Draw2DEditor : Editor
    {
        /// <summary>
        /// Reordable list for the points
        /// </summary>
        ReorderableList reList;
        /// <summary>
        /// Size of the handles to show in the scene view
        /// </summary>
        protected float handleSize = 0.5f;

        /// <summary>
        /// Target casted to Draw2D type
        /// </summary>
        Draw2D myTarget;

        void OnEnable()
        {
            myTarget = target as Draw2D;

            //Generate Reordable list
            reList = new ReorderableList(myTarget.vertices, typeof(List<Vector2>), true, false, true, true);

            reList.drawHeaderCallback = (Rect rect) => {
                EditorGUI.LabelField(rect, "Vertices");
            };

            //Assing a function for the undo command
            Undo.undoRedoPerformed += MyUndoCallback;
        }

        void MyUndoCallback()
        {
            //On Undo, remake the mesh
            myTarget.MakeMesh();
        }

        /// <summary>
        /// Add a new point to the mesh
        /// </summary>
        private void AddPoint()
        {
           //Only execute of can get the mouse position
            if (Event.current != null)
            {
                //Calculate mouse position on the screen
                Vector3 pos = Event.current.mousePosition;
                pos.y = Camera.current.pixelHeight - pos.y;
                
                pos.z = -Camera.current.transform.position.z;
                pos = Camera.current.ScreenToWorldPoint(pos);
				myTarget.vertices.Add(pos - myTarget.transform.position);
            }
           
        }
        /// <summary>
        /// Remove a point from the mesh
        /// </summary>
        /// <param name="index"></param>
        protected void RemovePoint(int index)
        {
            myTarget.vertices.RemoveAt(index);
        }

        private void OnSceneGUI()
        {
            //True if any action was executed
            bool executeAction = false;

            //If click with shift down, create a point
            if(Event.current.type == EventType.mouseDown && Event.current.shift)
            {
                if (Event.current.button == 0)
                {
                    Undo.RecordObject(target, "Adding point");
                    AddPoint();
                    executeAction = true;
                    myTarget.MakeMesh();
                }

            }

            

            EditorGUI.BeginChangeCheck();

            //Generate Handles and lines between the handles
            for (int i = myTarget.vertices.Count - 1; i >= 0 ; i--)
            {
                //Generate line
                if (i > 0)
					Handles.DrawLine(myTarget.vertices[i - 1] + myTarget.transform.position, myTarget.vertices[i] + myTarget.transform.position);

                //Generate Handle
                string name = "Handle " + i;
                GUI.SetNextControlName(name);
				myTarget.vertices[i] = Handles.FreeMoveHandle(myTarget.vertices[i] + myTarget.transform.position, Quaternion.identity, handleSize, Vector3.zero, Handles.RectangleHandleCap) - myTarget.transform.position;

                //If one handle is selected
                if (GUI.GetNameOfFocusedControl() == name)
                {
                    //And if del was pressed
                    if (Event.current.type == EventType.keyDown && Event.current.keyCode == KeyCode.Delete)
                    {
                        //Remove the selected point
                        Undo.RecordObject(target, "Removing point");
                        RemovePoint(i);
                        executeAction = true;
                        myTarget.MakeMesh();
                    }

                        
                }
                
            }
            //If some action was taken on the scene view with shift down, don't lose focus of this GameObject
            if (Event.current.type == EventType.Layout && Event.current.shift)
            {
                HandleUtility.AddDefaultControl(0);
            }
            //If any action was executed, don't lose focus of this GameObject
            if (executeAction)
            {
                Event.current.Use();
            }

            //If something changed, remake the mesh
            if (GUI.changed)
            {
                myTarget.MakeMesh();
            }

            //Generate a Undo record
            if (EditorGUI.EndChangeCheck())
            {

                Undo.RecordObject(target, "Changing position");
                EditorUtility.SetDirty(target);
            }
            
           

        }

        public override void OnInspectorGUI()
        {
            
            //Info about the script
            EditorGUILayout.HelpBox("Add: Shift + LClick\nDelete: Select a point and hit delete", MessageType.Info);

            //Toggles
            myTarget.generateMesh       = EditorGUILayout.Toggle("Generate Mesh", myTarget.generateMesh);
            myTarget.generateCollider   = EditorGUILayout.Toggle("Generate Collider", myTarget.generateCollider);
            myTarget.uvType = (Draw2D.UVType)EditorGUILayout.EnumPopup("UV type", myTarget.uvType);

            //Set Handle Size
            handleSize = EditorGUILayout.Slider("Handle Size", handleSize, 0, 1);

            //If something changed, remake the mesh
            if (GUI.changed)
            {
                myTarget.MakeMesh();
            }

            //Clear all the points of the mesh
            if (GUILayout.Button("Clear points"))
            {
                myTarget.CleanVertices();
                myTarget.MakeMesh();
            }

           
            //Show the reorder list, with all the vertices points
            reList.DoLayoutList();
        }


    }
    
}
