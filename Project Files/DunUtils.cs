using Dunhero;
using Dunhero.Creatures;
using Dunhero.DevelopmentTools;
using Dunhero.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace SampleMod
{
    internal class DunUtils
    {
        public static GameObject? GetGameObject(string name)
        {
            return GameObject.Find(name);
        }

        public static GameManager? GetGameManager()
        {
            GameObject? gameObject = GetGameObject("Game Manager");
            if (gameObject != null)
            {
                return gameObject.GetComponent<GameManager>();
            }
            else
            {
                return null;
            }
        }

        public static UIManager? GetUiManager()
        {
            GameObject? gameObject = GetGameObject("UI Manager");
            if (gameObject != null)
            {
                return gameObject.GetComponent<UIManager>();
            }
            else
            {
                return null;
            }
        }

        public static CheatManager? GetCheatManager()
        {
            GameObject? gameObject = GetGameObject("Cheat Manager");
            if (gameObject != null)
            {
                return gameObject.GetComponent<CheatManager>();
            }
            else
            {
                return null;
            }
        }

        public static Player[] GetPlayers()
        {
            GameManager? gm = GetGameManager();
            if (gm != null)
            {
                return gm.Players.ToArray();
            }
            else
            {
                return new Player[] { };
            }
        }

        public static Player? GetLocalPlayer()
        {
            foreach (Player p in GetPlayers())
            {
                if (p.IsLocalPlayer) return p;
            }
            return null;
        }

        public static object GetPrivateVariable<T>(Type typeof_instance_of_class, T instance_of_class, string the_name_of_the_private_variable)
        {
            Type type = typeof_instance_of_class;
            FieldInfo field = type.GetField(the_name_of_the_private_variable, BindingFlags.NonPublic | BindingFlags.Instance);
            return field.GetValue(instance_of_class);
        }

        public static void SetPrivateVariable<T1, T2>(Type typeof_instance_of_class, T1 instance_of_class, string the_name_of_the_private_variable, T2 variable_to_change_to)
        {
            Type type = typeof_instance_of_class;
            FieldInfo field = type.GetField(the_name_of_the_private_variable, BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(instance_of_class, variable_to_change_to);
        }

        public static void GetPrivateMethod<T>(Type typeof_instance_of_class, T instance_of_class, string the_name_of_the_private_variable, object[] the_arguments_of_the_method)
        {
            Type type = typeof_instance_of_class;
            MethodInfo privatemethod = type.GetMethod(the_name_of_the_private_variable);
            privatemethod.Invoke(instance_of_class, the_arguments_of_the_method);
        }

        public Character[] GetCharacters()
        {
            GameManager gm = GetGameManager();
            if (gm != null)
            {
                return gm.EntityManager.GetCharacters().ToArray<Character>();
            }
            else
            {
                return new Character[] { };
            }
        }

        public Character[] GetCharactersInRadius(Vector2 pos, float radius)
        {
            Character[] characters = GetCharacters();
            List<Character> result = new List<Character>();
            foreach (Character c in characters)
            {
                Vector2 c_pos = c.GetTransform().position;
                if (Vector2.Distance(pos, c_pos) <= radius)
                    result.Add(c);
            }
            return result.ToArray();
        }
    }
}
