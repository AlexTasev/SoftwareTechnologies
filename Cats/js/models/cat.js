const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    let Cat = sequelize.define("Cat",{
        name: {
            type: Sequelize.TEXT,
            required: true,
            allowNull: false
        },
        nickname: {
            type: Sequelize.TEXT,
            required: true,
            allowNull: false
        },
        price: {
            type: Sequelize.DOUBLE,
            required: true,
            allowNull: false
        }
        });

    return Cat;
};