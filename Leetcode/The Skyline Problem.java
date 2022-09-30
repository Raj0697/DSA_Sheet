class Solution {
    public List<List<Integer>> getSkyline(int[][] buildings) {
        TreeMap<Integer, List<int[]>> coor=new TreeMap<>(); //treeset for maintaing sorted coordinates
        for(int[] b: buildings) {
            //add left coordinate
            int arr[]=new int[2];
            List<int[]> l=coor.getOrDefault(b[0], new ArrayList<>());
            arr[0]=b[1]; //right coordinate
            arr[1]=b[2]; //height
            l.add(arr);
            coor.put(b[0], l);
            //add right coordinate
            arr=new int[2];
            l=coor.getOrDefault(b[1], new ArrayList<>());
            arr[0]=b[1]; //right coordinate
            arr[1]=b[2];//height
            l.add(arr);
            coor.put(b[1], l);
        }
        Queue<int[]> pq=new PriorityQueue<>((i, j)->(j[1]-i[1])); //max heap
        List<List<Integer>> ret=new ArrayList<>(); //answer list
        int lastLineHeight=-1; //last height 
        for(Map.Entry<Integer, List<int[]>> e: coor.entrySet()) {
            int x=e.getKey();
            List<int[]> val=e.getValue();
			//adding values in priority queue
            for(int[] a: val) {
                pq.add(a);
            }
            //removing those buildings whose right coordinate is already passed x
            while(!pq.isEmpty() && (pq.peek())[0]<=x) 
                pq.poll();
            
            int cur[]=new int[2];
            if(!pq.isEmpty()) {
                cur=pq.peek(); 
            } else {
			//priority queue is empty so adding 0
                cur[0]=x;
                cur[1]=0;
            }
            List<Integer> ans=new ArrayList<>();
            
            if(lastLineHeight!=cur[1]) { //last line should not be equal to current largest height building
                ans.add(x);
                ans.add(cur[1]);
                lastLineHeight=cur[1];
            }
            if(!ans.isEmpty())
            ret.add(ans);
        }
        return ret; //returning answer
    }
}
