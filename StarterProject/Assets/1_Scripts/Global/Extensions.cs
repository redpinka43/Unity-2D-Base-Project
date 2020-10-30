using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
// using Newtonsoft.Json;

namespace FluffyHippo
{
    public static class Extensions
    {
        public static Vector3 Vector3_changeX(Vector3 vector, float val)
        {
            return new Vector3(val, vector.y, vector.z);
        }
        public static Vector3 Vector3_changeY(Vector3 vector, float val)
        {
            return new Vector3(vector.x, val, vector.z);
        }
        public static Vector3 Vector3_changeZ(Vector3 vector, float val)
        {
            return new Vector3(vector.x, vector.y, val);
        }

        public static Vector3 Vector3_copy(Vector3 vector)
        {
            return new Vector3(vector.x, vector.y, vector.z);
        }
        public static Vector2 Vector2_copy(Vector3 vector)
        {
            return new Vector2(vector.x, vector.y);
        }

        public static Color SetColorAlpha(Color color, float alpha)
        {
            return new Color(color.r, color.g, color.b, alpha);
        }

        /* Need to install Newtonsoft.json package for this*/
        // public static T DeepCopy<T>(T obj)
        // {
        //     if (System.Object.ReferenceEquals(obj, null))
        //     {
        //         throw new Exception("The source object must not be null");
        //     }

        //     T result = default(T);
        //     string output = JsonConvert.SerializeObject(obj);
        //     result = JsonConvert.DeserializeObject<T>(output);

        //     return result;
        // }

        /// <summary>
        /// Gets rid of the string "(Clone)" at the end of a gameObject's name
        /// </summary>
        /// <param name="gameObject"></param>
        public static void GetRidOfCloneEnding(GameObject gameObject)
        {
            if ( gameObject.name.Substring(gameObject.name.Length - 7).Equals("(Clone)") ) 
            {
                gameObject.name = gameObject.name.Substring(0, gameObject.name.Length - 7);
            }
        }
    }
}