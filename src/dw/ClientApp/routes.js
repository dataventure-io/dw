"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
var react_router_dom_1 = require("react-router-dom");
var Layout_1 = require("./src/components/Layout");
var Home_1 = require("./src/components/Home");
var FetchEmployee_1 = require("./src/components/FetchEmployee");
var AddEmployee_1 = require("./src/components/AddEmployee");
exports.routes = React.createElement(Layout_1.Layout, null,
    React.createElement(react_router_dom_1.Route, { exact: true, path: '/', component: Home_1.Home }),
    React.createElement(react_router_dom_1.Route, { path: '/fetchemployee', component: FetchEmployee_1.FetchEmployee }),
    React.createElement(react_router_dom_1.Route, { path: '/addemployee', component: AddEmployee_1.AddEmployee }),
    React.createElement(react_router_dom_1.Route, { path: '/employee/edit/:empid', component: AddEmployee_1.AddEmployee }));
//# sourceMappingURL=routes.js.map