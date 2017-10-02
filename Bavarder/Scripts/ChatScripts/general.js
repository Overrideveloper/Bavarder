var genChat = {}

//Models
getChat.chatMessage = function (sender, content, dateSent) {
    var self = this;
    self.username = sender;
    self.content = content;
    if (dateSent != null) {
        self.timestamp = dateSent;
    }
}

genChat.user = function (username, userId) {
    var self = this;
    self.username = username;
    self.id = userId;
}

//Viewmodels
genChat.chatViewModel = function () {
    var self = this;
    self.this = ko.observableArray();
}

genChat.connectedUsersViewodel = function () {
    var self = this;
    self.contacts = ko.observableArray();
    self.customRemove = function (userToRemove) {
        var userIdToRemove = userToRemove.Id;
        self.contacts.remove(function (item) {
            return item.id === userIdToRemove;
        });
    }
}