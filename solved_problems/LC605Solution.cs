public class CanPlaceFlowersSolution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        for(int i = 0; i < flowerbed.Length; i++){
            if(flowerbed[i] == 0 && (i == 0 || flowerbed[i-1] == 0) && (i == flowerbed.Length-1 || flowerbed[i+1] == 0)){
                flowerbed[i] = 1;
                n--;;
            }
        }
        return n<=0;
    }
}

/*
 * You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.
   
   Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.
 */