const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    const Issue = sequelize.define('Issue' ,{
        title: {
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        content: {
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        priority: {
            type: Sequelize.INTEGER,
            allowNull: false,
            required: true
        }
    });

    return Issue;
};