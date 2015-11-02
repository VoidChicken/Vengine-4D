using System;
using System.Collections.Generic;
using System.IO;

namespace Vengine_Lib
{
    public class Mesh
    {
        public List<Vector3> vertexes = new List<Vector3>();
        public List<Vector3> normals = new List<Vector3>();
        public List<int[]> indices = new List<int[]>();
        private static Vector3 ParseV(string[] s)
        {
            Vector3 v = new Vector3();
            v.x = double.Parse(s[1]);
            v.y = double.Parse(s[2]);
            v.z = double.Parse(s[3]);
            return v;
        }
        private static int[] ParseF(string[] s)
        {
            int[] n = new int[s.Length-1];
            for (int x = 0; x < s.Length-1; x++)
            {
                n[x] = int.Parse(s[x + 1]);
            }
            return n;
        }
        public static Mesh From_VE_File(string fileName)
        {
            Mesh mesh = new Mesh();
            Stack<string> parse_que = new Stack<string>();
            foreach (string s in File.ReadAllLines(fileName)) {
                parse_que.Push(s);
            }

            for (int i = 0; i < parse_que.Count; i++) {
                string line = parse_que.Pop();
                string[] data = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                bool norm = false;
                if (data[0] == "pcn")
                {
                    norm = data[1] == "1";
                }
                if (data[0] == "v")
                {
                    mesh.vertexes.Add(ParseV(data));
                }
                if (data[0] == "f")
                {
                    mesh.vertexes.Add(ParseV(data));
                }
                if (data[0] == "n" && norm)
                {
                    mesh.normals.Add(ParseV(data));
                }
            }
            return mesh;
        }
    }
}
