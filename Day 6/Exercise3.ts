let statuses = [2,4,3,1,4,3];
for(let status of statuses) {
    console.log(getStatus(status));
}

function getStatus(statusNumber) {
    if (statusNumber === 1) {
        return "Alive";
    }
    else if (statusNumber === 2) {
        return "Zombie";
    }
    else if (statusNumber === 3) {
        return "Dead";
    }
    else {
        return "Unknown";
    }
}