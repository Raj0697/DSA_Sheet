LinkedList<int> minq = new LinkedList<int>();
        LinkedList<int> maxq = new LinkedList<int>();
        
        int l =0, r=0;
        
        int max = 0;
        while(r<nums.Length)
        {
            while(maxq.Count>0 && maxq.Last.Value<nums[r]){
                maxq.RemoveLast();
            }
            
            maxq.AddLast(nums[r]);
            
            while(minq.Count>0 && minq.Last.Value > nums[r]){
                minq.RemoveLast();
            }
            
            minq.AddLast(nums[r]);
            
            while(maxq.First.Value-minq.First.Value>limit)
            {
                if(minq.First.Value == nums[l]) minq.RemoveFirst();
                if(maxq.First.Value == nums[l]) maxq.RemoveFirst();
                l++;
            }
            
            max = Math.Max(max,r-l+1);
            r++;
        }
        
        return max;
