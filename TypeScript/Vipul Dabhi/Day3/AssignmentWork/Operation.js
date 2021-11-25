"use strict";
exports.__esModule = true;
exports.operation = void 0;
var ApplicantList;
var InterviewScheduleList;
var interviewResult;
var HiredApplicant;
var operation = /** @class */ (function () {
    function operation() {
    }
    operation.prototype.storeApplicantData = function (data) {
        ApplicantList.push(data);
        for (var _i = 0, ApplicantList_1 = ApplicantList; _i < ApplicantList_1.length; _i++) {
            var i = ApplicantList_1[_i];
            console.log("Applicant Id is ".concat(i.Id, " name is ").concat(i.Name, " Gender is ").concat(i.Gender, " Qualification is ").concat(i.Qualification, " Age is ").concat(i.Age, "."));
        }
        console.log("Applicant Data is Added");
    };
    operation.prototype.scheduleInterview = function (data) {
        InterviewScheduleList.push(data);
        for (var _i = 0, InterviewScheduleList_1 = InterviewScheduleList; _i < InterviewScheduleList_1.length; _i++) {
            var i = InterviewScheduleList_1[_i];
            console.log("Applicant Id is ".concat(i.ApplicantId, " name is ").concat(i.ApplicantName, " NameOfInterviewer is ").concat(i.NameOfInterviewer, " Date of is ").concat(i.date, " Location is ").concat(i.location, "."));
        }
        console.log("Interview is Scheduled for Listed Applicant");
    };
    operation.prototype.interviewResult = function (data) {
        interviewResult.push(data);
    };
    operation.prototype.hiringApplicant = function () {
        console.log("List of Appliant who Cleare Interview");
        for (var _i = 0, interviewResult_1 = interviewResult; _i < interviewResult_1.length; _i++) {
            var i = interviewResult_1[_i];
            if (HiredApplicant.length <= 20) {
                if (i.IsSelected === true) {
                    HiredApplicant.push(i);
                }
            }
            else {
                console.log("No Vacancies");
            }
        }
        console.log("This Employees Are Hired");
        for (var _a = 0, HiredApplicant_1 = HiredApplicant; _a < HiredApplicant_1.length; _a++) {
            var x = HiredApplicant_1[_a];
            console.log("".concat(i.ApplicantName, " is Hired"));
        }
    };
    operation.prototype.report = function () {
        console.log("This Employees Are Apply For Interview \n");
        for (var _i = 0, interviewResult_2 = interviewResult; _i < interviewResult_2.length; _i++) {
            var x = interviewResult_2[_i];
            console.log("".concat(x.ApplicantName, "\n"));
        }
        console.log("This Employees Are Hired \n");
        for (var _a = 0, HiredApplicant_2 = HiredApplicant; _a < HiredApplicant_2.length; _a++) {
            var y = HiredApplicant_2[_a];
            console.log("".concat(y.ApplicantName, "\n"));
        }
    };
    return operation;
}());
exports.operation = operation;
