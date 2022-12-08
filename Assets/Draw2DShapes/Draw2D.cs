using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Draw2DShapesLite
{
    /// <summary>
    /// Draw 2D shapes on the scene of the Unity
    /// </summary>
    public class Draw2D : MonoBehaviour {

        public enum UVType
        {
            fit,
            repeat
        }

        /// <summary>
        /// Generate a Mesh for this shape?
        /// </summary>
        public bool generateMesh = true;
        /// <summary>
        /// Generate a collider for this shape?
        /// </summary>
        public bool generateCollider = true;

        /// <summary>
        /// All points that will be used as vertices for the shape
        /// </summary>
        public List<Vector3> vertices = new List<Vector3>();
        /// <summary>
        /// Triangles that will be used for the shape
        /// </summary>
        public List<int> triangles = new List<int>();

        /// <summary>
        /// Type of uv
        /// </summary>
        public UVType uvType;

        /// <summary>
        /// Mesh for the shape
        /// </summary>
        protected Mesh mesh;
       
       /// <summary>
       /// Remove all the vertices(points) for the shape
       /// </summary>
        public void CleanVertices()
        {
            vertices.Clear();
        }

        /// <summary>
        /// Create a new Mesh using the current points for the shape
        /// </summary>
        public void MakeMesh()
        {
            if (this == null)
                return;

            mesh = new Mesh();
            triangles.Clear();

            //2D points for the Polygon collider
			Vector2[] vertices2D = new Vector2[vertices.Count];

            for (int i = 0; i < vertices.Count; i++)
            {
                vertices2D[i] = vertices[i];
            }

            //Triangulate the indices for the mesh
			Triangulator tri = new Triangulator(vertices2D);
            int[] indices = tri.Triangulate();
            
            //Assing data for the new mesh
            mesh.vertices = vertices.ToArray();
            mesh.triangles = indices;
            mesh.RecalculateBounds();
            mesh.RecalculateNormals();
            

            MeshFilter filter = GetComponent<MeshFilter>();
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            
            //Create the components if have a mesh
            if (generateMesh)
            {
                if (filter == null)
                    filter = gameObject.AddComponent<MeshFilter>();
                if (renderer == null)
                {
                    gameObject.AddComponent<MeshRenderer>();
                    GetComponent<Renderer>().material = new Material(Shader.Find("Specular"));
                }

                filter.sharedMesh = mesh;

                Vector2[] uv = new Vector2[vertices.Count];

                if(uvType == UVType.fit)
                {
                    for (int i = 0; i < vertices.Count; i++)
                    {
                        uv[i] = new Vector2((vertices[i].x - mesh.bounds.min.x) / (mesh.bounds.max.x - mesh.bounds.min.x), (vertices[i].y - mesh.bounds.min.y) / (mesh.bounds.max.y - mesh.bounds.min.y));
                    }
                }
                else
                {
                    for (int i = 0; i < vertices.Count; i++)
                    {
                        uv[i] = new Vector2(vertices[i].x - mesh.bounds.min.x, vertices[i].y - mesh.bounds.min.y);
                    }
                }

                mesh.uv = uv;

            }
            //Else, destroy the components for the mesh
            else
            {
                if (filter != null)
                    DestroyImmediate(filter);
                if (renderer != null)
                    DestroyImmediate(renderer);
            }

            PolygonCollider2D collider = GetComponent<PolygonCollider2D>();
            //Create the components for the collider
            if (generateCollider)
            {
                if (collider == null)
                    collider = gameObject.AddComponent<PolygonCollider2D>();
				collider.points = vertices2D;
            }
            //Else, destroy the components for the collider
            else
            {
                if (collider != null)
                    DestroyImmediate(collider);
            }

        }

       
       
    }
}
