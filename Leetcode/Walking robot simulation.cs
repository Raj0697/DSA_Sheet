var set = new HashSet<string>();
        foreach(var o in obstacles) set.Add(o[0]+","+o[1]);
        int[] direct = new int[]{0,1,0,-1,0};
        int x=0, y=0, k=0, res=0;
        foreach(var c in commands){
            if (c==-1) k++;
            else if (c==-2) k+=3;
            else{
                k%=4;
                for (int i=0; i<c; i++){
                    int X=x+direct[k], Y=y+direct[k+1];
                    if (set.Contains(X+","+Y)) break;
                    x=X;
                    y=Y;
                }
            }
            res = res>(x*x+y*y)?res:(x*x+y*y);
        } 
        return res;
