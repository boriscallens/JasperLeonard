﻿$(function () {
    $("html, body").mousewheel(function (event, delta) {
        this.scrollLeft -= (delta * 100);
        event.preventDefault();
    });
});