var Employ = /** @class */ (function () {
    function Employ(empno, name, basic) {
        this.empno = empno;
        this.name = name;
        this.basic = basic;
    }
    return Employ;
}());
var obj1 = new Employ(1, "Pralavi", 84823);
console.log("Employ No ".concat(obj1.empno, "  Employ Name ").concat(obj1.name, " \n                Salary ").concat(obj1.basic));
