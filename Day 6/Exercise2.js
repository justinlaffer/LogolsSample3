let Tests = [1,3,3,4, 2, 4, 2];

let nametest = [
    {nametest:4,name:'Elliott'},
    {nametest:2,name:'Sam'},
    {nametest:1,name:'Justin'},
    {nametest:3,name:'Ben'}
  
];

let counter=0;
while(counter<Tests.length) {
    console.log(getTest(Tests[counter]));
    console.log(Tests[counter]);
    counter++;
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

 /*
  for(let counter=0; counter< Tests.length; counter++){  
   console.log(getTest(Tests));

    function getTest(Tests) {
        if(Tests === 1) {
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
 do {
     let status= Tests[counter];
     console.log(Tests[counter]);counter++;
 
     function getTest(Tests) {
            if(Tests === 1) {
                return "Alive";
                }
                else if(Tests === 2) {
                    return "Zombie";
                }
                else if(Tests === 3) {
                    return "Dead";
                }
                else if(Tests=== 4) {
                    return "Unknown";
                }
    }
 } while(counter<Tests.length)

 for(let person of Tests) {
    console.log(getTest(Tests));
 }

     function getTest(Tests) {
         if(Tests === 1) {
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
     
    } */

switch(Tests)
 {
    case 1:
     console.log('The government employee is Alive');
     break;
    case 2:
     console.log('The government employee is a Zombie');
     break;
    case 3:
     console.log('The government employee is Dead');
     break;
    default:
    console.log('The current status of the government employee is Unknown');
    break;
 }
