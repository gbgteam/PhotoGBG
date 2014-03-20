function TagModel() {
    var self = this;
    self.Id = ko.observable();
    self.Name = ko.observable();
    self.AddedBy = ko.observable();

    self.init = function (data) {
        self.Id(data.Id);
        self.Name(data.Name);
        self.AddedBy(data.AddedBy);
    };
};

function TagsModule() {
    var self = this;

    if (arguments.callee.instance)
        return arguments.callee.instance;
    arguments.callee.instance = self;

    self.Tags = ko.observableArray();
    self.init = function (data, id, tf) {
        if (data.IsSuccess) {
            self.Tags.removeAll();
            for (var i in data.Tags) {
                var tag = new TagModel();
                tag.init(data.Tags[i]);
                self.Tags.push(tag);
            }
        }
        if (tf == true) {
            ko.applyBindings(self, document.getElementById(id));
        }
    };
};
TagsModule.getInstance = function () {
    var singletonClass = new TagsModule();
    return singletonClass;
};
