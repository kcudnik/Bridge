Bridge.define('System.Collections.Generic.Comparer$1', function (T) {
    return {
        inherits: [System.Collections.Generic.IComparer$1(T)],

        constructor: function (fn) {
            this.fn = fn;
            this.compare = fn;
        }
    }
});

System.Collections.Generic.Comparer$1.$default = new System.Collections.Generic.Comparer$1(Object)(function (x, y) {
    if (!Bridge.hasValue(x)) {
        return !Bridge.hasValue(y) ? 0 : -1;
    } else if (!Bridge.hasValue(y)) {
        return 1;
    }

    return Bridge.compare(x, y);
});