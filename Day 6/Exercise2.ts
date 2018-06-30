
let Tests = [1,3,3,4, 2, 4, 2];

let count=0;
while(count<Tests.length) {
    console.log(getTest(Tests[count]));
    console.log(Tests[count]);
    count++;
 }

 function getTest(Tests) {
    if(Tests=== 1) {
        return "Alive";
    }
    else if(Tests === 2) {
        return "Zombie";
    }
    else if(Tests === 3) {
        return "Dead";
    }
    else if(Tests === 4) {
        return "Unknown";
    }
 }







