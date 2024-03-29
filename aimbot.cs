int lowDistMax = 75;

double lowDist = lowDistMax;
float aimPosX = this.Width/2, aimPosY = this.Height/2;

void AimAtPos(float x, float y)
        {
            float ScreenCenterX = (this.Width / 2);
            float ScreenCenterY = (this.Height / 2);
            float TargetX = 0;
            float TargetY = 0;
            if (x != 0)
            {
                if (x > ScreenCenterX)
                {
                    TargetX = -(ScreenCenterX - x);
                    TargetX /= AimSpeed;
                    if (TargetX + ScreenCenterX > ScreenCenterX * 2) TargetX = 0;
                }
 
                if (x < ScreenCenterX)
                {
                    TargetX = x - ScreenCenterX;
                    TargetX /= AimSpeed;
                    if (TargetX + ScreenCenterX < 0) TargetX = 0;
                }
            }
            if (y != 0)
            {
                if (y > ScreenCenterY)
                {
                    TargetY = -(ScreenCenterY - y);
                    TargetY /= AimSpeed;
                    if (TargetY + ScreenCenterY > ScreenCenterY * 2) TargetY = 0;
                }
 
                if (y < ScreenCenterY)
                {
                    TargetY = y - ScreenCenterY;
                    TargetY /= AimSpeed;
                    if (TargetY + ScreenCenterY < 0) TargetY = 0;
                }
            }
            if (!smooth)
            {
                mouse_event(0x0001, (uint)(TargetX), (uint)(TargetY), NULL, NULLPTR);
                return;
            }
            TargetX /= 10;
            TargetY /= 10;
            if (Math.Abs(TargetX) < 1)
            {
                if (TargetX > 0)
                {
                    TargetX = 1;
                }
                if (TargetX < 0)
                {
                    TargetX = -1;
                }
            }
            if (Math.Abs(TargetY) < 1)
            {
                if (TargetY > 0)
                {
                    TargetY = 1;
                }
                if (TargetY < 0)
                {
                    TargetY = -1;
                }
            }
            mouse_event(0x0001, (uint)TargetX, (uint)TargetY, NULL, NULLPTR);
        }