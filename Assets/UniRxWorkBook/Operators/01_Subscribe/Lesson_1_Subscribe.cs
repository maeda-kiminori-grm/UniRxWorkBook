﻿using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

namespace UniRxWorkBook.Operators
{
    public class Lesson_1_Subscribe : MonoBehaviour
    {
        private void Start()
        {
            // _____()の部分を正しい形に置換してCubeが回転するようにしよう
			this.UpdateAsObservable().Subscribe(a => RotateCube());
        }

        private void RotateCube()
        {
            this.transform.rotation = Quaternion.AngleAxis(1.0f, Vector3.up)*this.transform.rotation;
        }
    }
}
