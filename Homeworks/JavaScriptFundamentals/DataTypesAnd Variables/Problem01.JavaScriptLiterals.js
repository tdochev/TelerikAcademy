var literalsArray,
    i,
    array = ['array'],
    boolean = true,
    floatingPoint = 3.14,
    integers = 42,
    object = {firstname: 'Gosho'},
    regex = /ab+c/,
    string = 'Javascript',
    nullvariable = null,
    undefinedVariable;

var literalsArray = [array, boolean, floatingPoint, integers, object, regex, string, nullvariable, undefinedVariable];

for (i = 0; i < literalsArray.length; i += 1) {
    console.log(literalsArray[i] + ' ' +typeof(literalsArray[i]));
}
