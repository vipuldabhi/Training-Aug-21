var myVar

function starttime() {

    myVar = setTimeout(function () {

        alert("Exam is Over!!!");

    }, 10800000)

}

function submit() {

    examsubmit().then(

        (resolve) => {
            alert(resolve);
            clearTimeout(myVar);
        },
        (reject) => {
            alert(reject);
        }

    )
}

function examsubmit() {

    var mypromise = new Promise(function (resolve, reject) {

        var notover = "If You Want To Submit Exam Then Press Ok!!!";

        var over = "Exam is over No need to submit";

        if (myVar) {

            alert("Exam Time is Not Over Yet!!");
            resolve(notover);

        } else {

            reject(over);

        }
    })
    return mypromise;
}


