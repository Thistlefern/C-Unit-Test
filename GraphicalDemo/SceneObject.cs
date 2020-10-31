using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;
using System.Diagnostics;
using MathClasses;

using static Raylib_cs.Raylib;  // core methods (InitWindow, BeginDrawing())
using static Raylib_cs.Color;   // color (RAYWHITE, MAROON, etc.)

namespace GraphicalDemo
{
    class SceneObject
    {
        protected SceneObject parent = null;
        protected List<SceneObject> children = new List<SceneObject>();
        protected Matrix3 localTransform = new Matrix3();
        protected Matrix3 globalTransform = new Matrix3();
        public Matrix3 LocalTransform
        {
            get { return localTransform; }
        }
        public Matrix3 GlobalTransform
        {
            get { return globalTransform; }
        }
        public SceneObject Parent
        {
            get { return parent; }
        }
        public SceneObject()
        {
            if (parent != null)
            {
                parent.RemoveChild(this);
            }
            foreach (SceneObject so in children)
            {
                so.parent = null;
            }
        }
        public int GetChildCount()
        {
            return children.Count;
        }
        public SceneObject GetChild(int index)
        {
            return children[index];
        }
        public void AddChild(SceneObject child)
        {
            // make sure it doesn't have a parent already
            Debug.Assert(child.parent == null);
            // assign "this as parent
            child.parent = this;
            // add new child to collection
            children.Add(child);
        }
        public void RemoveChild(SceneObject child)
        {
            if (children.Remove(child) == true)
            {
                child.parent = null;
            }
        }

        protected virtual void OnUpdate(float deltaTime)
        {

            // use these to manipulate the object
            // Translate
            // Rotate
            // Scale

            // do these only once when you initialize the object
            // SetRotate or SetScale (not both - this is a design flaw in the tutorial)
            // SetPosition
        }
        protected virtual void OnDraw()
        {
            //// red blip at position
            //DrawCircle((int)globalTransform.m7, (int)globalTransform.m8, 10f, RED);

            //// draw forward - m1 and m2 (x and y axes of the forward vector)
            ////               
            ////                adding the forwad vector to our position so we can put the line on the circle
            //float fwdX = globalTransform.m1 * 90.0f + globalTransform.m7;
            //float fwdY = globalTransform.m2 * 90.0f + globalTransform.m8;

            //DrawLine((int)globalTransform.m7, (int)globalTransform.m8, (int)fwdX, (int)fwdY, RED);

            //// x scale is equal to the magnitude of the X-axis (m1 and m2)
            //// y scale is equal to the magnitude of the Y-axis (m4 and m5)
            //float sclX = (float)Math.Sqrt(globalTransform.m1 * globalTransform.m1 + globalTransform.m2 * globalTransform.m2);
            //float sclY = (float)Math.Sqrt(globalTransform.m4 * globalTransform.m4 + globalTransform.m5 * globalTransform.m5);
        }
        public void Update(float deltaTime)
        {
            // run OnUpdate behaviour
            OnUpdate(deltaTime);
            // update children
            foreach (SceneObject child in children)
            {
                child.Update(deltaTime);
            }
        }
        public void Draw()
        {
            // run OnDraw behaviour
            OnDraw();
            // draw children
            foreach (SceneObject child in children)
            {
                child.Draw();
            }
        }

        public void UpdateTransform()
        {
            if (parent != null)
                globalTransform = parent.globalTransform * localTransform;
            else
                globalTransform = localTransform;
            foreach (SceneObject child in children)
                child.UpdateTransform();
        }

        public void SetPosition(float x, float y)
        {
            localTransform.SetTranslation(x, y);
            UpdateTransform();
        }
        public void SetRotate(float radians)
        {
            localTransform.SetRotateZ(radians);
            UpdateTransform();
        }
        public void SetScale(float width, float height)
        {
            localTransform.SetScaled(width, height, 1);
            UpdateTransform();
        }
        public void Translate(float x, float y)
        {
            localTransform.Translate(x, y);
            UpdateTransform();
        }
        public void Rotate(float radians)
        {
            localTransform.RotateZ(radians);
            UpdateTransform();
        }
        public void Scale(float width, float height)
        {
            localTransform.Scale(width, height, 1);
            UpdateTransform();
        }
    }
}
