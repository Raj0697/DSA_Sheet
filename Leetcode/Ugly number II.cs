int[] arr = new int[n];
        arr[0] = 1;
        int p2 = 0, p3 = 0, p5 = 0;
        
        for(int i = 1; i < n; i++)
        {
            int num1 = 2 * arr[p2];
            int num2 = 3 * arr[p3];
            int num3 = 5 * arr[p5];
            
            arr[i] = Math.Min(num1, Math.Min(num2, num3));
            
            if(num1 == arr[i])
                p2++;
            if(num2 == arr[i])
                p3++;
            if(num3 == arr[i])
                p5++;
        }
        
        return arr[n-1];
