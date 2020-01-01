﻿using System;
using UnityEngine;

namespace FBSAssist
{
    // Token: 0x02001032 RID: 4146
    public class TimeProgressCtrl
    {
        // Token: 0x06008665 RID: 34405 RVA: 0x00349D43 File Offset: 0x00348143
        public TimeProgressCtrl(float ptime = 0.15f)
        {
            this.progressTime = ptime;
        }

        // Token: 0x06008666 RID: 34406 RVA: 0x00349D68 File Offset: 0x00348168
        public void End()
        {
            this.count = this.progressTime;
            this.rate = 1f;
        }

        // Token: 0x06008667 RID: 34407 RVA: 0x00349D81 File Offset: 0x00348181
        public void Start()
        {
            this.count = 0f;
            this.rate = 0f;
        }

        // Token: 0x06008668 RID: 34408 RVA: 0x00349D9C File Offset: 0x0034819C
        public float Calculate()
        {
            this.count += Time.deltaTime;
            if (this.count < this.progressTime)
            {
                this.rate = Mathf.InverseLerp(0f, this.progressTime, this.count);
            }
            else
            {
                this.End();
            }
            return this.rate;
        }

        // Token: 0x06008669 RID: 34409 RVA: 0x00349DF9 File Offset: 0x003481F9
        public void SetProgressTime(float time)
        {
            this.progressTime = time;
        }

        // Token: 0x0600866A RID: 34410 RVA: 0x00349E02 File Offset: 0x00348202
        public float GetProgressRate()
        {
            return this.rate;
        }

        // Token: 0x04006CEC RID: 27884
        private float count;

        // Token: 0x04006CED RID: 27885
        private float rate = 1f;

        // Token: 0x04006CEE RID: 27886
        private float progressTime = 0.15f;
    }
}